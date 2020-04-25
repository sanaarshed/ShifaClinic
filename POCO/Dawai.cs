
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.POCO
{
    public class Dawai
    {
        public int id { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public string type { get; set; }
        public string content { get; set; }
        public string alsoKnownAs { get; set; }
        public string brandName { get; set; }
    }

    public class Shards
    {
        public int total { get; set; }
        public int successful { get; set; }
        public int skipped { get; set; }
        public int failed { get; set; }
    }

    public class Source
    {
        public string id { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string uri { get; set; }
        public string stripPerPack { get; set; }
        public string type { get; set; }
        public string content { get; set; }
        public string alsoKnownAs { get; set; }
        public string redirect { get; set; }
        public string categoryId { get; set; }
        public string entityType { get; set; }
        public string brandName { get; set; }
    }

    public class Hit
    {
        public string _index { get; set; }
        public string _type { get; set; }
        public string _id { get; set; }
        public double _score { get; set; }
        public Source _source { get; set; }
    }

    public class Hits
    {
        public int total { get; set; }
        public double max_score { get; set; }
        public List<Hit> hits { get; set; }
    }

    public class DawaiResponseRootObject
    {
        public int took { get; set; }
        public bool timed_out { get; set; }
        public Shards _shards { get; set; }
        public Hits hits { get; set; }
    }
}
