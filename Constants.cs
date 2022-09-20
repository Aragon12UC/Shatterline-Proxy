using System.Collections.Generic;

namespace ShatterlineProxy {
    static class Constants {
        public static readonly Dictionary<string, string> ULTIMATE_ABILITIES = new Dictionary<string, string> {
            { "ult_sr05", "Crystalline Sniper" },
            { "ult_ik01", "" },
            { "ult_gl01", "Grenade Launcher" },
        };

        public static readonly string[] CHARACTER_NAMES = new string[] { 
            "m_malva",
            "m_pill",
            "a_orbit",
            "h_strix",
            "a_mongoose",
            "s_kite",
            "s_brisa",
            "h_ram"
        };

        public static readonly string[] WEAPON_NAMES = new string[] {
            "ar04",
            "pt12",
            "shg08",
            "sr03",
            "shg05",
            "ar09",
            "ar05",
            "pt05",
            "ar07",
            "sr11",
            "smg03",
            "smg02",
            "sr08",
            "pt10",
            "ar08",
            "pt07",
            "pt11",
            "shg04",
            "shg06",
            "shg07",
            "smg04",
            "smg05",
            "smg06",
            "sr06",
            "sr10"
        };

        /// <summary>
        /// slot_name : item_name. MAY NOT CONTAIN ALL PERKS.
        /// </summary>
        public static readonly Dictionary<string, string> PERKS = new Dictionary<string, string> {
            { "tactical_mode_perk", "tactical_mode_perk" },
            { "movability_perk", "movability_perk_fast" },
            { "regeneration_perk", "regeneration_perk" },
            { "invisibility_perk", "invisibility_perk" },
            { "zipline_using_device", "zipline_using_device" },
            { "highclimb_perk", "highclimb_perk" },
            { "bomb_using_device", "bomb_using_device" },
            { "resurrect_speed_perk", "paired_resurrect_perk" },
            { "primary_backpack_perk", "primary_backpack_default_perk" },
            { "tokens_perk", "tokens_manager_perk" },
            { "destruction_perk", "destruction_perk" },
            { "overhaste_perk", "overhaste_perk" }
        };
    }
}
