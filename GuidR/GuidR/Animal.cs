using System;
using System.Collections.Generic;

// The shared properties between all animals

namespace GuidR.Droid
{
    public class Animal : Attraction
    {
        // Lav CTOR'en om til CTOR chaining

        public Animal(string name, string description, Coordinates location, int imgSource, string latinName, params Time[] feedingTimes)
            : base(name, description, location)
        {
            this.LatinName = latinName;
            this._headerImage = imgSource;
            foreach (Time t in feedingTimes)
                this.FeedingTimes.Add(t);
        }

        public Animal(string name, string description, Coordinates location, string latinName, int imgSource, Time feedingTime)
            : base(name, description, location)
        {
            this.LatinName = latinName;
            this.FeedingTimes.Add(feedingTime);
            this._headerImage = imgSource;
        }

      /*  public Animal(string name, string description, Coordinates location, string latinName, int imgSource, Time feedingTime)
            : base(name, description, location)
        {
            this.LatinName = latinName;
            this.FeedingTimes.Add(feedingTime);
        }
        */

        public Animal(string name, string description, Coordinates location, string latinName, int imgSource)
            : base(name, description, location)
        {
            this._headerImage = imgSource;
            this.LatinName = latinName;
            this.FeedingTimes = null;
        }

        public string LatinName
        {
            get; set;
        }

        public Time NextFeeding
        {
            get
            {
                if (FeedingTimes.Count == 1)
                    return FeedingTimes[0];

                // If the animal is feed more than once a day, get the nearest feeding time
                else
                {
                    Time nearestFeedingTime = FeedingTimes[0];

                    foreach (Time t in FeedingTimes)
                    {
                        if (/*t.TimeOfDay > DateTime.Now && */t.TimeOfDay < nearestFeedingTime.TimeOfDay && !t.IsPassed)
                            nearestFeedingTime = t;
                    }

                    return nearestFeedingTime;
                }
            }
        }

        private int _headerImage;

        public int HeaderImage {
            get { return _headerImage; }
            set { _headerImage = value; }
        }


        private List<Time> _feedingTimes = new List<Time>();

        public List<Time> FeedingTimes
        {
            get
            {
                return _feedingTimes;
            }
            set
            {
                _feedingTimes = value;
            }
        }
    }
}

/*public Animal (string name) : this (name, "") { }
public Animal (string name, string latinName) : this (name, latinName, null) { }*/
