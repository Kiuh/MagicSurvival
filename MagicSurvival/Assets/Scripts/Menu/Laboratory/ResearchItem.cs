using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ResearchItem : MonoBehaviour, IPointerClickHandler
{
    public string ResearchName;
    public bool active = false;
    public ResearchGridManager rgm;
    [SerializeField]
    Text ForResearchName;
    [SerializeField]
    Text ForResearchDescription;
    RectTransform rect;
    ButtonScale bs;
    Image image;
    [SerializeField]
    GameObject point1;
    [SerializeField]
    GameObject point2;
    private void Start()
    {
        rgm = this.GetComponentInParent<ResearchGridManager>();
        rect = this.GetComponent<RectTransform>();
        bs = this.GetComponent<ButtonScale>();
        image = this.GetComponentInChildren<Image>();
        CheckColor();
    }
    public void CheckColor()
    {
        for (int i = 0; i < GlobalInfo.ResearchPointsInvested.Length / 2; i++)
        {
            if (GlobalInfo.ResearchPointsInvested[i, 0] == ResearchName)
            {
                if (GlobalInfo.ResearchPointsInvested[i, 1] == "0")
                {
                    image.color = Color.gray;
                }
                else if(GlobalInfo.ResearchPointsInvested[i, 1] == "1") 
                {
                    image.color = Color.yellow;
                }
                else
                {
                    image.color = Color.red;
                }
                break;
            }
        }
    }
    public void CheckWhiteColor()
    {
        for (int i = 0; i < GlobalInfo.ResearchPointsInvested.Length / 2; i++)
        {
            if (GlobalInfo.ResearchPointsInvested[i, 0] == ResearchName)
            {
                if (GlobalInfo.MagesMasterProcent[i, 1] == "0")
                {
                    image.color = Color.white;
                }
                else if (GlobalInfo.MagesMasterProcent[i, 1] == "1")
                {
                    image.color = new Color(250, 236, 182);
                }
                else
                {
                    image.color = new Color(225, 175, 126);
                }
                break;
            }
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!active) {
            rgm.ShowTwoButtons();
            point1.SetActive(true);
            point2.SetActive(true);
            rgm.Clear();
            bs.active = false;
            rect.localScale = new Vector3(bs.max_scale, bs.max_scale, 1);
            CheckWhiteColor();
            ForResearchName.text = ResearchName;
            active = true;
            rgm.ChoosedResearch = ResearchName;
            for (int i = 0; i < GlobalInfo.ResearchDescriptions.Length / 3; i++)
            {
                if (GlobalInfo.ResearchDescriptions[i, 0] == ResearchName)
                {
                    int k = 0;
                    for (int j = 0; j < GlobalInfo.ResearchPointsInvested.Length / 2; j++)
                    {
                        if (GlobalInfo.ResearchPointsInvested[j, 0] == ResearchName)
                        {
                            k = Convert.ToInt32(GlobalInfo.ResearchPointsInvested[j, 1]);
                            break;
                        }
                    }
                    if (k == 0 || k == 1)
                    {
                        ForResearchDescription.text = GlobalInfo.ResearchDescriptions[i, 1];
                        if (k == 0)
                        {
                            point1.GetComponent<Image>().color = Color.gray;
                            point2.GetComponent<Image>().color = Color.gray;
                        }
                        else if (k == 1)
                        {
                            point1.GetComponent<Image>().color = Color.yellow;
                            point2.GetComponent<Image>().color = Color.gray;
                        }
                    }
                    else if (k == 2)
                    {
                        ForResearchDescription.text = GlobalInfo.ResearchDescriptions[i, 2];
                        point1.GetComponent<Image>().color = Color.yellow;
                        point2.GetComponent<Image>().color = Color.yellow;
                    }
                    break;
                }
                if (i == GlobalInfo.ResearchDescriptions.Length / 2 - 1)
                {
                    ForResearchDescription.text = "Not found";
                }
            }
        }
        else 
        {
            rgm.ShowOneButton();
            ToNormal();
            point1.SetActive(false);
            point2.SetActive(false);
            ForResearchName.text = "Research";
            ForResearchDescription.text = "Choose Your Research";
            rgm.ChoosedResearch = "None";
        }
    }
    public void AsClicked() 
    {
        rgm.ShowTwoButtons();
        point1.SetActive(true);
        point2.SetActive(true);
        rgm.Clear();
        bs.active = false;
        rect.localScale = new Vector3(bs.max_scale, bs.max_scale, 1);
        CheckWhiteColor();
        ForResearchName.text = ResearchName;
        active = true;
        rgm.ChoosedResearch = ResearchName;
        for (int i = 0; i < GlobalInfo.ResearchDescriptions.Length / 3; i++)
        {
            if (GlobalInfo.ResearchDescriptions[i, 0] == ResearchName)
            {
                int k = 0;
                for (int j = 0; j < GlobalInfo.ResearchPointsInvested.Length / 2; j++)
                {
                    if (GlobalInfo.ResearchPointsInvested[j, 0] == ResearchName)
                    {
                        k = Convert.ToInt32(GlobalInfo.ResearchPointsInvested[j, 1]);
                        break;
                    }
                }
                if (k == 0 || k == 1)
                {
                    ForResearchDescription.text = GlobalInfo.ResearchDescriptions[i, 1];
                    if (k == 0)
                    {
                        point1.GetComponent<Image>().color = Color.gray;
                        point2.GetComponent<Image>().color = Color.gray;
                    }
                    else if (k == 1)
                    {
                        point1.GetComponent<Image>().color = Color.yellow;
                        point2.GetComponent<Image>().color = Color.gray;
                    }
                }
                else if (k == 2)
                {
                    ForResearchDescription.text = GlobalInfo.ResearchDescriptions[i, 2];
                    point1.GetComponent<Image>().color = Color.yellow;
                    point2.GetComponent<Image>().color = Color.yellow;
                }
                break;
            }
            if (i == GlobalInfo.ResearchDescriptions.Length / 2 - 1)
            {
                ForResearchDescription.text = "Not found";
            }
        }
    }
    public void ToNormal()
    {
        if (active)
        {
            bs.active = true;
            rect.localScale = new Vector3(bs.min_scale, bs.min_scale, 1);
            CheckColor();
            active = false;
        }
    }
}
