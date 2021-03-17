using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResearchGridManager : MonoBehaviour
{
    [SerializeField]
    GameObject parent;
    Sprite[] sprites;
    [SerializeField]
    GameObject example;
    Image ex_image;
    float cell_width;
    float cell_height;
    RectTransform rect;
    RectTransform rect_child;
    GridLayoutGroup gridLayout;
    [SerializeField]
    public string ChoosedResearch = "None";
    [SerializeField]
    List<ResearchItem> ccis;
    [SerializeField]
    GameObject ButtonBuy;
    [SerializeField]
    GameObject ButtonInvest;
    [SerializeField]
    GameObject ButtonRetrieve;
    [SerializeField]
    GameObject point1;
    [SerializeField]
    GameObject point2;
    [SerializeField]
    Text FreePoints;
    void Awake()
    {
        ShowOneButton();
        sprites = Resources.LoadAll<Sprite>("ResearchIcons");
        rect = this.GetComponent<RectTransform>();
        gridLayout = this.GetComponent<GridLayoutGroup>();
        ex_image = example.GetComponentInChildren<Image>();
        rect_child = example.GetComponentInChildren<RectTransform>();
        example.SetActive(true);
    }
    private void Start()
    {
        point1.SetActive(false); point1.GetComponent<Image>().color = Color.gray;
        point2.SetActive(false); point2.GetComponent<Image>().color = Color.gray;
        cell_width = rect.sizeDelta.x / 8;
        cell_height = rect.sizeDelta.y / 3;
        gridLayout.cellSize.Set(cell_width, cell_height);
        //Debug.Log(cell_width + " " + cell_height + " " + gridLayout.cellSize);
        cell_width = (rect.sizeDelta.x * 0.9f) / 8;
        cell_height = (rect.sizeDelta.y * 0.9f) / 3;
        FreePoints.text = "Research points: " + GlobalInfo.FreeResearchPoints;
        foreach (Sprite item in sprites.Reverse())
        {
            ex_image.sprite = item;
            ex_image.SetNativeSize();
            /*if(ex_image.sprite.rect.width > ex_image.sprite.rect.height) 
            {
                float coef = cell_width / ex_image.sprite.rect.width;
                rect_child.sizeDelta.Set(cell_width, ex_image.sprite.rect.height * coef);
            }
            else 
            {
                float coef = cell_height / ex_image.sprite.rect.height;
                rect_child.sizeDelta.Set(ex_image.sprite.rect.width * coef, cell_height);
            }*/
            //rect_child.sizeDelta.Set(cell_width, cell_height);
            GameObject gameObject = Instantiate(example, this.transform);
            ccis.Add(gameObject.GetComponent<ResearchItem>());
            ccis[ccis.Count - 1].ResearchName = ex_image.sprite.name;
        }
        example.SetActive(false);
    }
    public void Close() 
    {
        GameObject.Destroy(parent);
    }
    public void Clear()
    {
        point1.GetComponent<Image>().color = Color.gray;
        point2.GetComponent<Image>().color = Color.gray;
        foreach (ResearchItem item in ccis)
        {
            item.ToNormal();
        }
    }
    public void ButtonBuyResearchPoint() 
    {
    
    }
    public void ButonInvest() 
    {
        if (GlobalInfo.FreeResearchPoints > 0)
        {
            for (int i = 0; i < GlobalInfo.ResearchPointsInvested.Length / 2; i++)
            {
                if (GlobalInfo.ResearchPointsInvested[i, 0] == ChoosedResearch)
                {
                    if (GlobalInfo.MagesMasterProcent[i, 1] == "0")
                    {
                        GlobalInfo.MagesMasterProcent[i, 1] = "1";
                    }
                    else if (GlobalInfo.MagesMasterProcent[i, 1] == "1")
                    {
                        GlobalInfo.MagesMasterProcent[i, 1] = "2";
                    }
                    break;
                }
            }
            foreach (ResearchItem item in ccis)
            {
                if(item.ResearchName == ChoosedResearch) { item.AsClicked(); }
            }
        }
        FreePoints.text = "Research points: " + GlobalInfo.FreeResearchPoints;
    }
    public void ButonRetrieve()
    {
        for (int i = 0; i < GlobalInfo.ResearchPointsInvested.Length / 2; i++)
        {
            if (GlobalInfo.ResearchPointsInvested[i, 0] == ChoosedResearch)
            {
                if (GlobalInfo.MagesMasterProcent[i, 1] == "1")
                {
                    GlobalInfo.MagesMasterProcent[i, 1] = "0";
                }
                else if (GlobalInfo.MagesMasterProcent[i, 1] == "2")
                {
                    GlobalInfo.MagesMasterProcent[i, 1] = "1";
                }
                break;
            }
        }
        foreach (ResearchItem item in ccis)
        {
            if (item.ResearchName == ChoosedResearch) { item.AsClicked(); }
        }
        FreePoints.text = "Research points: " + GlobalInfo.FreeResearchPoints;
    }

    public void ShowTwoButtons() 
    {
        ButtonBuy.SetActive(false);
        ButtonInvest.SetActive(true);
        ButtonRetrieve.SetActive(true);
    }
    public void ShowOneButton()
    {
        ButtonBuy.SetActive(true);
        ButtonInvest.SetActive(false);
        ButtonRetrieve.SetActive(false);
    }
}
