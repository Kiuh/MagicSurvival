using UnityEngine;

public class GlobalInfo : MonoBehaviour
{
    public static int points = 0;
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
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
