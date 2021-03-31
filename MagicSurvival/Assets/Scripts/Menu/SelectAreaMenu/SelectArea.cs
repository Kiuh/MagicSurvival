using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectArea : MonoBehaviour
{
    [SerializeField]
    string CloseSceneName = "MainMenu";
    [SerializeField]
    string PLaySceneName = "Gameplay";
    [SerializeField]
    Text AreaName;
    [SerializeField]
    Text AreaDescription;
    [SerializeField]
    Text AreaBestTime;
    [SerializeField]
    Text AreaModifications;
    [SerializeField]
    Image AreaImage;
    [SerializeField]
    Image LeftArrow;
    [SerializeField]
    Image RightArrow;
    Sprite[] sprites;
    private int CurrentArea = 1;
    public void Awake()
    {
        sprites = Resources.LoadAll<Sprite>("Areas");
    }
    public void Start()
    {
        ShowCurrentArea();
    }
    public void ButtonLeftArrow() 
    {
        if (CurrentArea != 1) 
        {
            CurrentArea--;
            ShowCurrentArea();
        }  
    }
    public void ButtonRightArrow() 
    {
        string NextArea = "Null";
        for (int i = 0; i < GlobalInfo.AreasOrder.Length / 2; i++)
        {
            if (Convert.ToInt32(GlobalInfo.AreasOrder[i, 1]) == CurrentArea + 1)
            {
                NextArea = GlobalInfo.AreasOrder[i, 0];
            }
        }
        for (int i = 0; i < GlobalInfo.AreasOpened.Length / 2; i++)
        {
            if (GlobalInfo.AreasOpened[i, 0] == NextArea && GlobalInfo.AreasOpened[i, 1] == "Open")
            {
                CurrentArea++;
                ShowCurrentArea();
                break;
            }
        }
    }
    private void ShowCurrentArea() 
    {
        for (int i = 0; i < GlobalInfo.AreasOrder.Length/2; i++)
        {
            if (Convert.ToInt32(GlobalInfo.AreasOrder[i, 1]) == CurrentArea)
                AreaName.text = GlobalInfo.AreasOrder[i, 0];
        }
        for (int i = 0; i < GlobalInfo.AreasDescriptions.Length/2; i++)
        {
            if (GlobalInfo.AreasDescriptions[i, 0] == AreaName.text)
                AreaDescription.text = GlobalInfo.AreasDescriptions[i, 1];
        }
        for (int i = 0; i < GlobalInfo.AreasBestTime.Length / 2; i++)
        {
            if (GlobalInfo.AreasBestTime[i, 0] == AreaName.text)
                AreaBestTime.text = "Best time: " + GlobalInfo.AreasBestTime[i, 1];
        }
        for (int i = 0; i < GlobalInfo.AreasModifications.Length / 2; i++)
        {
            if (GlobalInfo.AreasModifications[i, 0] == AreaName.text)
                AreaModifications.text = "Modiifications: " + GlobalInfo.AreasModifications[i, 1];
        }
        foreach (Sprite item in sprites)
        {
            if (item.name == AreaName.text)
                AreaImage.sprite = item;
        }
        if (CurrentArea == 1) 
            LeftArrow.color = Color.gray;
        else
            LeftArrow.color = Color.white;
        RightArrow.color = Color.gray;
        string NextArea = "Null";
        for (int i = 0; i < GlobalInfo.AreasOrder.Length / 2; i++)
        {
            if (Convert.ToInt32(GlobalInfo.AreasOrder[i, 1]) == CurrentArea + 1) 
            {
                NextArea = GlobalInfo.AreasOrder[i, 0];
            }
        }
        for (int i = 0; i < GlobalInfo.AreasOpened.Length / 2; i++)
        {
            if (GlobalInfo.AreasOpened[i, 0] == NextArea && GlobalInfo.AreasOpened[i, 1] == "Open")
                RightArrow.color = Color.white;
        }
    }
    public void ButtonPlay() 
    {
        GlobalInfo.SelectedArea = AreaName.text;
        SceneManager.LoadScene(PLaySceneName);
    }
    public void Close() 
    {
        SceneManager.LoadScene(CloseSceneName);
    }
}
