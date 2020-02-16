using System.Collections.Generic;

public class Data
    {
        public Dictionary<string, string> dict { get; set; }

        public Data()
        {
           dict = new Dictionary<string, string>()
    {
        {"a","4"},
        {"b","8"},
        {"e","3"},
        {"i","!"},
        {"o","0"}
    };
        }
    }