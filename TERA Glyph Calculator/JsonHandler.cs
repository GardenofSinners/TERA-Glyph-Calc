using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TERA_Glyph_Calculator {

    public partial class JsonHandler {

        public class Glyph {

            public string name { get; set; }
            public string level { get; set; }
            public string cost { get; set; }
            public string description { get; set; }
            public string image { get; set; }
            public string master { get; set; }
            public string id { get; set; }
            public string group { get; set; }
            public string highest { get; set; }
            public string rare { get; set; }
        }

        public class Skill {
            public List<Glyph> glyph { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }

        public class Class {
            public List<Skill> skill { get; set; }
            #region For Gridview 
            [JsonIgnore] public string A { get; set; }
            [JsonIgnore] public string B { get; set; }
            #endregion
        }

        public class RootObject {
            public Class @class { get; set; }
        }

    }
}
