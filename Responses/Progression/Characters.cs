using System.Collections.Generic;

namespace ShatterlineProxy.Responses.Progression {
    class Characters {
        public List<Character> characters { get; set; }

        public class Character {
            public string name { get; set; }
            public int level { get; set; }
            public int score { get; set; }
        }
    }
}
