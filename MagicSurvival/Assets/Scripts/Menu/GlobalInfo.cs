using UnityEngine;

public class GlobalInfo : MonoBehaviour
{
    public static int Coins = 0;
    public static int FreeResearchPoints = 10;
    public static int MaxResearchPoints = 10;
    public static string SelectedAvatar = "Human";
    public static string[,] MagesDescriptions = new string[24, 2]
    {
        { "Archemist","" },
        { "Archmage","" },
        { "Astronomer","" },
        { "Bard","" },
        { "Battle Mage","" },
        { "Bishop","" },
        { "Dark Mage","" },
        { "Druid","" },
        { "Electromancer","" },
        { "Elementalist","" },
        { "Enchantress","" },
        { "Invoker","" },
        { "Kabbalist","" },
        { "Lich","" },
        { "Mage","" },
        { "Magician","" },
        { "Scholar","" },
        { "Shaman","" },
        { "Socerer","" },
        { "Summoner","" },
        { "Warlock","" },
        { "Warlord","" },
        { "Witch","" },
        { "Wizard","" }
    };
    public static string[,] MagesMasterProcent = new string[24, 2]
    {
        { "Archemist","0" },
        { "Archmage","0" },
        { "Astronomer","0" },
        { "Bard","0" },
        { "Battle Mage","0" },
        { "Bishop","0" },
        { "Dark Mage","0" },
        { "Druid","0" },
        { "Electromancer","0" },
        { "Elementalist","0" },
        { "Enchantress","0" },
        { "Invoker","0" },
        { "Kabbalist","0" },
        { "Lich","0" },
        { "Mage","0" },
        { "Magician","0" },
        { "Scholar","0" },
        { "Shaman","0" },
        { "Socerer","0" },
        { "Summoner","0" },
        { "Warlock","0" },
        { "Warlord","0" },
        { "Witch","0" },
        { "Wizard","0" }
    };
    public static string[,] MagesOpened = new string[24, 2]
    {
        { "Archemist","Close" },
        { "Archmage","Close" },
        { "Astronomer","Close" },
        { "Bard","Close" },
        { "Battle Mage","Close" },
        { "Bishop","Close" },
        { "Dark Mage","Close" },
        { "Druid","Close" },
        { "Electromancer","Close" },
        { "Elementalist","Close" },
        { "Enchantress","Close" },
        { "Invoker","Close" },
        { "Kabbalist","Close" },
        { "Lich","Close" },
        { "Mage","Close" },
        { "Magician","Close" },
        { "Scholar","Close" },
        { "Shaman","Close" },
        { "Socerer","Close" },
        { "Summoner","Close" },
        { "Warlock","Close" },
        { "Warlord","Close" },
        { "Witch","Close" },
        { "Wizard","Open" }
    };
    public static string[,] AvatarsOpened = new string[5, 2]
    {
        { "Human","Open"},
        { "Witch","Close"},
        { "Deamon","Close"},
        { "Pumpkin","Close"},
        { "Spirit","Close"},
    };
    public static string[,] AvatarsPrices = new string[5, 2]
    {
        { "Human","0"},
        { "Witch","1000"},
        { "Deamon","1200"},
        { "Pumpkin","1300"},
        { "Spirit","1400"},
    };
    public static string[,] AvatarsEffects = new string[5, 2]
    {
        { "Human","+8% exp gains"},
        { "Witch","+7% instant death rate"},
        { "Deamon","+8% all outcoming damage"},
        { "Pumpkin","+15% speed"},
        { "Spirit","+10% magic cooldown"},
    };
    public static string[,] AvatarsDescriptions = new string[5, 2]
    {
        { "Human","Simple but inventive kind of creature, not very special, basically fool but pretty traineble."},
        { "Witch","The witch, a mysterious person, loves death and doom.  The best companion is a cat."},
        { "Deamon","The spawn of darkness, the fiend of hell, the devil himself favors him, loves to devour the environment."},
        { "Pumpkin","The pumpkin is a gourd, a mindless creature, but one of the most terrifying of the demonic kind."},
        { "Spirit","It is not a creature, it is the essence of mana, the closest relative of the magician, instant connection."},
    };
    public static string[,] ResearchDescriptions = new string[24, 3]
    {
        { "Intelligence","","" },
        { "Combat Mastery","","" },
        { "Vitality","","" },
        { "Resistence","","" },
        { "Haste","","" },
        { "Mana Refine","","" },
        { "Regeneration","","" },
        { "Bio Mana","","" },
        { "Magic Circle","","" },
        { "Propagating","","" },
        { "High Speed Casting","","" },
        { "Explorer","","" },
        { "Rejuvenation","","" },
        { "Recycle","","" },
        { "Shade","","" },
        { "Meditation","","" },
        { "Curse","","" },
        { "Nerve Barrier","","" },
        { "Dark Magic","","" },
        { "Blood Thirst","","" },
        { "Prophecy","","" },
        { "Archeology","","" },
        { "Knowleage","","" },
        { "Arcane Effuse","","" }
    };
    public static string[,] ResearchPointsInvested = new string[24, 2]
    {
        { "Intelligence","0" },
        { "Combat Mastery","0" },
        { "Vitality","0" },
        { "Resistence","0" },
        { "Haste","0" },
        { "Mana Refine","0" },
        { "Regeneration","0" },
        { "Bio Mana","0" },
        { "Magic Circle","0" },
        { "Propagating","0" },
        { "High Speed Casting","0" },
        { "Explorer","0" },
        { "Rejuvenation","0" },
        { "Recycle","0" },
        { "Shade","0" },
        { "Meditation","0" },
        { "Curse","0" },
        { "Nerve Barrier","0" },
        { "Dark Magic","0" },
        { "Blood Thirst","0" },
        { "Prophecy","0" },
        { "Archeology","0" },
        { "Knowleage","0" },
        { "Arcane Effuse","0" }
    };
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
