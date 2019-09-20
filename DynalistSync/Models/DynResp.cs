using System;
using System.Collections.Generic;

namespace DynalistSync.Models
{
    
        public class DynFile
        {
            public string id { get; set; }
            public string title { get; set; }
            public string type { get; set; }
            public int permission { get; set; }
            public bool? collapsed { get; set; }
            public List<string> children { get; set; }
        }

        public class DynResp
    {
            public string _code { get; set; }
            public string _msg { get; set; }
            public string root_file_id { get; set; }
            public List<DynFile> files { get; set; }
        }
    
}
