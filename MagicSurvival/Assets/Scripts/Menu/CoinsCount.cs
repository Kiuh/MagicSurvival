using UnityEngine;
using UnityEngine.UI;

public class CoinsCount : MonoBehaviour
{
    [SerializeField]
    Text text;
    private void Start()
    {
        text = this.GetComponent<Text>();
    }
    void Update()
    {
        text.text = $"Coins: {GlobalInfo.points}";
    }
}
