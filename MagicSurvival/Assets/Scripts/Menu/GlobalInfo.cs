using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInfo : MonoBehaviour
{
    public static int points = 0;
    string[,] descriptions = new string[24, 2]
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
        { "Sorcer","" },
        { "Summoner","" },
        { "Warlock","" },
        { "Warlord","" },
        { "Witch","" },
        { "Wizard","" }
    };
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
