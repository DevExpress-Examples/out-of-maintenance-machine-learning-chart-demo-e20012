using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ml.Attributes;

namespace MachineLearningDemo.Data
{
    public class Feed
    {
        public string Source { get; set; }

        [StringFeature(SplitType=StringType.Word)]
        public string Content { get; set; }

        public int Cluster { get; set; }
    }
}
