namespace ShatterlineProxy.Responses.Progression {
    class Weapons {
        public int tier { get; set; }
        public int mastery_score { get; set; }
        public Weapon[] weapons { get; set; }

        public class Weapon {
            public string name { get; set; }
            public int score { get; set; }
            public int level { get; set; }
            public bool locked { get; set; }
        }
    }
}
