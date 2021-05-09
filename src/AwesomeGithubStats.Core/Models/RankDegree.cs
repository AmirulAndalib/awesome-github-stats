﻿using System.Collections.Generic;
using System.Linq;

namespace AwesomeGithubStats.Core.Models
{
    public class RankDegree : List<Degree>
    {


        public Degree InRange(double value)
        {
            foreach (var range in this.OrderByDescending(o => o.Points))
            {
                if (value >= range.Points)
                    return range;
            }

            return this.OrderByDescending(o => o.Points).Last();
        }
    }

    public class Degree
    {
        public string Rank { get; set; }
        public int Points { get; set; }
        /// <summary>
        /// If false it doesn't affect the progress bar
        /// </summary>
        public bool CountSliceProgressBar { get; set; }
    }
}
