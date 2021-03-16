using UnityEngine;

public class GlobalInfo : MonoBehaviour
{
    public static int Coins = 10000;
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
        { "Human","+1 brutal"},
        { "Witch","+2 brutal"},
        { "Deamon","+3 brutal"},
        { "Pumpkin","+4 brutal"},
        { "Spirit","+5 brutal"},
    };
    public static string[,] AvatarsDescriptions = new string[5, 2]
    {
        { "Human","Like a Human"},
        { "Witch","Like a Witch"},
        { "Deamon","Like a Deamon"},
        { "Pumpkin","Like a Pumpkin"},
        { "Spirit","Like a Spirit"},
    };
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
