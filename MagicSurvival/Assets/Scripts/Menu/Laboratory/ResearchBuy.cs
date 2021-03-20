using System;
using UnityEngine;
using UnityEngine.UI;

public class ResearchBuy : MonoBehaviour
{
    [SerializeField]
    Text title;
    [SerializeField]
    Text leftValue;
    [SerializeField]
    Text rightValue;
    void Start()
    {
        Refresh();
    }
    public void Buy() 
    {
        if(GlobalInfo.CurrentPriceForPoints <= GlobalInfo.Coins)
        {
            GlobalInfo.Coins -= GlobalInfo.CurrentPriceForPoints;
            GlobalInfo.MaxResearchPoints++;
            GlobalInfo.CurrentPriceForPoints += GlobalInfo.StepForPoints;
            Refresh();
        }
    }
    void Refresh() 
    {
        title.text = "Price for 1 point: " + GlobalInfo.CurrentPriceForPoints;
        leftValue.text = Convert.ToString(GlobalInfo.MaxResearchPoints);
        rightValue.text = Convert.ToString(GlobalInfo.MaxResearchPoints + 1);
    }
    public void Close() 
    {
        this.gameObject.SetActive(false);
    }
}
