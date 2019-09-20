using System;
using System.Collections.Generic;

namespace DynalistSync.Models
{
    public class Node
    {
        public string id { get; set; }
        public string content { get; set; }
        public string note { get; set; }
        public object created { get; set; }
        public object modified { get; set; }
        public List<object> children { get; set; }
        public bool? @checked { get; set; }
        public bool? checkbox { get; set; }
        public int? color { get; set; }
        public int? heading { get; set; }
        public bool? collapsed { get; set; }
    }

    public class DynDoc
    {
        public string _code { get; set; }
        public string _msg { get; set; }
        public string title { get; set; }
        public int version { get; set; }
        public List<Node> nodes { get; set; }
    }
}
