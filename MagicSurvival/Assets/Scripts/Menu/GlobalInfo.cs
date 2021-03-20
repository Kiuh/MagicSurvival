using UnityEngine;

public class GlobalInfo : MonoBehaviour
{
    public static int Coins = 10000;
    public static int CurrentPriceForPoints = 1000;
    public static int StepForPoints = 100;
    public static int FreeResearchPoints = 10;
    public static int MaxResearchPoints = 10;
    public static string SelectedAvatar = "Human";
    public static string[,] MagesDescriptions = new string[24, 3]
    {
        { "Archemist","Energy Bolt lvl +1, Energy Bolt Damage, Duration, Size +22%","Energy Bolt lvl +1, Energy Bolt Damage, Duration, Size, Projectile Speed +30%" },
        { "Archmage","Tsunami lvl +1, Tsunamy Size +20%, Tsunami Cooldown -10%","Tsunami lvl +1, Tsunamy Size,Damage +20%, Tsunami Cooldown -15%" },
        { "Astronomer","Setellite lvl +1, Create Setellite +1, Setellite damage, size +15%","Setellite lvl +1, Create Setellite +2, Setellite damage, size, rotation speed +18%" },
        { "Bard","Vitality lvl +1, HP Recovery per sec +0.3%","Vitality lvl +2, HP Recovery per sec +0.6%" },
        { "Battle Mage","Hight Speed Casting lvl +1, Magic Cooldown -3%","Hight Speed Casting lvl +2, Magic Cooldown -6%" },
        { "Bishop","Shield lvl +1, Shield Cooldown -20%","Shield lvl +1, Shield Cooldown -25%, Number of Shields +1" },
        { "Dark Mage","Execution lvl +1, Corpse Explosion lvl +1, Corpse Explosion Damage, Radius +10%","Execution lvl +2, Corpse Explosion lvl +2, Corpse Explosion Damage, Radius +20%" },
        { "Druid","Cyclone lvl +1, Cyclone Duration +20%, Cyclone Cooldown -10%","Cyclone lvl +1, Cyclone Duration +40%, Cyclone Cooldown -20%" },
        { "Electromancer","Electric Zone lvl +1, Electric Zone Damage, Size +15%","Electric Zone lvl +1, Electric Zone Damage, Size +22%, Electric Zone Attac Interval -15%" },
        { "Elementalist","Incineration lvl +1, Frost Nova lvl +1, Incineration,Frost Nova Cooldown -10%","Incineration lvl +1, Frost Nova lvl +1, Incineration,Frost Nova Cooldown -25%" },
        { "Enchantress","Magic radius, Size, Duration, Number if magic +8%","Magic radius, Size, Duration, Number if magic +15%" },
        { "Invoker","Magic Bolt lvl +1, Magic Bolt Damage +10%, Magic Bolt Penetration +1","Magic Bolt lvl +1, Magic Bolt Damage, Rate of fire +20%, Magic Bolt Penetration +2" },
        { "Kabbalist","Cloaking lvl +1, Cloaking Duration +50%","Cloaking lvl +1, Cloaking Duration +50%, Cloaking Cooldown -20%" },
        { "Lich","Armaggedon lvl +1, Armageddon Cooldown -13sec, Max HP -33%","Armaggedon lvl +1, Armageddon Cooldown -20sec, Max HP -25%" },
        { "Mage","Blizzard lvl +1, Blizzard Damage +10%, Number of Blizzard +30%","Blizzard lvl +1, Blizzard Damage, Duration +20%, Number of Blizzard +35% " },
        { "Magician","25% chance to fire random projectile, when casting the Magic Bolt","50% chance to fire random projectile, when casting the Magic Bolt, Magic Bolt rate of fire +20%" },
        { "Scholar","Exp Gains +10%, Number of Ability Opinion +1","Exp Gains +20%, Number of Ability Opinion +2" },
        { "Shaman","Thunderstorm lvl +1, Thunderstorm Damage +15%, Thunderstorm Cooldown -10%","Thunderstorm lvl +2, Thunderstorm Damage +20%, Thunderstorm Cooldown -20%" },
        { "Socerer","Electric Shok lvl +1, Min Nimber of Electric Shok +1, Electric Shok CoolDown -5%","Electric Shok lvl +2, Min Nimber of Electric Shok +2, Electric Shok CoolDown -15%" },
        { "Summoner","Spirit lvl +1, Create spirit +1, Spirit rate of fire +15%","Spirit lvl +1, Create spirit +2, Spirit rate of fire +25%" },
        { "Warlock","Meteor lvl +1, Meteor damage +15%, Meteor radius +10%","Meteor lvl +2, Meteor damage +15%, Meteor radius +20%, Meteor Cooldown - 20%" },
        { "Warlord","Incineration lvl +1, Incineration Damage +20%, Number of Incineration +20%","Incineration lvl +2, Incineration Damage,Duration +20%, Number of Incineration +30%" },
        { "Witch","Fireball lvl +1, Fireball Damage +50%","Fireball lvl +2, Fireball Damage +70%, Fireball Cooldown -15%" },
        { "Wizard","Basic School","Master of basic achool :)" }
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
        { "Kabbalist","Open" },
        { "Lich","Close" },
        { "Mage","Close" },
        { "Magician","Close" },
        { "Scholar","Close" },
        { "Shaman","Open" },
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
        { "Elf","Close"},
        { "Deamon","Close"},
        { "Pumpkin","Close"},
        { "Spirit","Close"},
    };
    public static string[,] AvatarsPrices = new string[5, 2]
    {
        { "Human","0"},
        { "Elf","1700"},
        { "Deamon","2000"},
        { "Pumpkin","2100"},
        { "Spirit","2400"},
    };
    public static string[,] AvatarsEffects = new string[5, 2]
    {
        { "Human","+8% exp gains"},
        { "Elf","+7% instant death rate"},
        { "Deamon","+8% all outcoming damage"},
        { "Pumpkin","+15% speed"},
        { "Spirit","-10% magic cooldown"},
    };
    public static string[,] AvatarsDescriptions = new string[5, 2]
    {
        { "Human","Simple but inventive kind of creature, not very special, basically fool but pretty traineble."},
        { "Elf","The elf, a mysterious person, loves death and doom.  The best companion is a cat."},
        { "Deamon","The spawn of darkness, the fiend of hell, the devil himself favors him, loves to devour the environment."},
        { "Pumpkin","The pumpkin is a gourd, a mindless creature, but one of the most terrifying of the demonic kind."},
        { "Spirit","It is not a creature, it is the essence of mana, the closest relative of the magician, instant connection."},
    };
    public static string[,] ResearchDescriptions = new string[24, 3]
    {
        { "Intelligence","All outcoming damage +7%","All outcoming damage +15%" },
        { "Combat Mastery","Magic Bolt Rate of Fire +15%","Magic Bolt Rate of Fire +25%" },
        { "Vitality","Max HP +20%, HP Globe Heal Amount +30%","Max HP +35%, HP Globe Heal Amount +45%" },
        { "Resistance","Damage Taken -10%","Damage Taken -20%" },
        { "Haste","Movment Speed +7%","Movment Speed +13%" },
        { "Mana Refine","Exp Gains +10%","Exp Gains +17%" },
        { "Regeneration","HP Recovery per sec +0.1%","HP Recovery per sec +0.165%" },
        { "Bio Mana","Restore 0.7% Max HP when gain Exp Globe","Restore 1.5% Max HP when gain Exp Globe" },
        { "Magic Circle","Magic Effect Duration +13%","Magic Effect Duration +22%" },
        { "Propagating","Number of Magic +13%","Number of Magic +22%" },
        { "High Speed Casting","Magic Cooldown -4%","Magic Cooldown -8%" },
        { "Explorer","Item Pickup Range +30%","Item Pickup Range +60%" },
        { "Rejuvenation","Restore 15% when lvl up","Restore 22% when lvl up" },
        { "Recycle","Mp taken +20% when choose 'Mp taken' in the ability board","Mp taken +30% when choose 'Mp taken' in the ability board" },
        { "Shade","Invisibility Duration +30%","Invisibility Duration +45%" },
        { "Meditation","When Character not moving, HP Recovery per sec +0.5%","When Character not moving, HP Recovery per sec +0.8%" },
        { "Curse","Enemy Hp -12%, Damage Taken +20%","Enemy Hp -17%, Damage Taken +17%" },
        { "Nerve Barrier","Invisibility 1sec when get hit","Invisibility 2sec when get hit" },
        { "Dark Magic","Instant Death Rate +3%, All outcoming damage -15%","Instant Death Rate +6%, All outcoming damage -20%" },
        { "Blood Thirst","All outcoming damage +30% when HP less than 20%","All outcoming damage +40% when HP less than 30%" },
        { "Prophecy","Restore 40% Max Hp every 5 minutes","Restore 70% Max Hp every 4 minutes" },
        { "Archeology","Get a random Rare Artifact at the start","Get a random Legendary Artifact at the start" },
        { "Knowledge","Starting lvl +1","Starting lvl +3" },
        { "Arcane Effuse","Magic Radius +7%, Magic Size +7%","Magic Radius +12%, Magic Size +12%" }
    };
    public static string[,] ResearchPointsInvested = new string[24, 2]
    {
        { "Intelligence","0" },
        { "Combat Mastery","0" },
        { "Vitality","0" },
        { "Resistance","0" },
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
        { "Knowledge","0" },
        { "Arcane Effuse","0" }
    };
    public static string[,] AreasDescriptions = new string[5, 2]
    {
        { "Array Zone","Something about Array Zone"},
        { "Laboratory","Something about Laboratory"},
        { "Sewerage","Something about Sewerage"},
        { "Outskirt","Something about Outskirt"},
        { "Arboretum","Something about Arboretum"},
    };
    public static string[,] AreasBestTime = new string[5, 2]
    {
        { "Array Zone","00:00"},
        { "Laboratory","00:00"},
        { "Sewerage","00:00"},
        { "Outskirt","00:00"},
        { "Arboretum","00:00"},
    };
    public static string[,] AreasGoal = new string[5, 2]
    {
        { "Array Zone","The goal is survive as long as posibble"},
        { "Laboratory","The goal is survive as long as posibble"},
        { "Sewerage","The goal is survive as long as posibble"},
        { "Outskirt","The goal is survive as long as posibble"},
        { "Arboretum","The goal is survive as long as posibble"},
    };
    public static string[,] AreasModifications = new string[5, 2]
    {
        { "Array Zone","No Modifications"},
        { "Laboratory","Reward +30%"},
        { "Sewerage","Reward +50%, Starting level +10"},
        { "Outskirt","Reward +80%"},
        { "Arboretum","Reward +100%"},
    };
    public static string[,] AreasOpened = new string[5, 2]
    {
        { "Array Zone","Open"},
        { "Laboratory","Open"},
        { "Sewerage","Open"},
        { "Outskirt","Open"},
        { "Arboretum","Close"},
    };
    public static string[,] AreasOrder = new string[5, 2]
    {
        { "Array Zone","1"},
        { "Laboratory","2"},
        { "Sewerage","3"},
        { "Outskirt","4"},
        { "Arboretum","5"},
    };
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
