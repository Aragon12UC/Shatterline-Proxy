using System.Collections.Generic;

namespace ShatterlineProxy.Responses.Inventory {
    class InventoryItems {
        public string item_name { get; set; }
        public List<Slot> slots { get; set; }
        public int amount { get; set; }
        public int capacity { get; set; }
        public bool seen { get; set; }

        public class Slot {
            public string slot_name { get; set; }
            public string item_name { get; set; }
        }
    }
}
