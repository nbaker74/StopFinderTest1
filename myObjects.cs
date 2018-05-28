using System.Collections.Generic;

namespace StopFinderTest1
{

    public class Parent
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Location
    {
        public string id { get; set; }
        public string name { get; set; }
        public string disassembledName { get; set; }
        public List<double> coord { get; set; }
        public string type { get; set; }
        public int matchQuality { get; set; }
        public bool isBest { get; set; }
        public List<int> modes { get; set; }
        public Parent parent { get; set; }
    }

    public class myObjects
    {
        public string version { get; set; }
        public List<Location> locations { get; set; }
    }
}
