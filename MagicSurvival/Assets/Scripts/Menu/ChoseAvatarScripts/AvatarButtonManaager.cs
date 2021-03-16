using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarButtonManaager : MonoBehaviour
{
    [SerializeField]
    GameObject Parent;

    [SerializeField]
    Image WitchShadow;
    [SerializeField]
    Image HumanShadow;
    [SerializeField]
    Image DeamonShadow;
    [SerializeField]
    Image SpiritShadow;
    [SerializeField]
    Image PumpkinShadow;

    [SerializeField]
    public Text AvatarName;
    [SerializeField]
    public Text AvatarFlavor;
    [SerializeField]
    public Text AvatarEffects;
    [SerializeField]
    public Text ApplyButton;

    [SerializeField]
    string SelectedAvatar;
    public void Start()
    {
        SelectedAvatar = GlobalInfo.SelectedAvatar;
        ShowAboutAvatar();
        UpdateShadows();
    }
    public void Witch() 
    {
        SelectedAvatar = "Witch";
        ShowAboutAvatar();
        UpdateShadows();
    }
    public void Spirit()
    {
        SelectedAvatar = "Spirit";
        ShowAboutAvatar();
        UpdateShadows();
    }
    public void Human()
    {
        SelectedAvatar = "Human";
        ShowAboutAvatar();
        UpdateShadows();
    }
    public void Pumpkin()
    {
        SelectedAvatar = "Pumpkin";
        ShowAboutAvatar();
        UpdateShadows();
    }
    public void Deamon()
    {
        SelectedAvatar = "Deamon";
        ShowAboutAvatar();
        UpdateShadows();
    }
    public void Apply_Select_Buy() 
    {
        if (ApplyButton.text == "Apply")
        {
            GameObject.Destroy(Parent);
        }
        else if (ApplyButton.text == "Select")
        {
            GlobalInfo.SelectedAvatar = SelectedAvatar;
            ShowAboutAvatar();
        }
        else
        {
            int price = 0;
            for (int i = 0; i < GlobalInfo.AvatarsPrices.Length / 2; i++)
            {
                if (GlobalInfo.AvatarsPrices[i, 0] == SelectedAvatar)
                {
                    price = Convert.ToInt32(GlobalInfo.AvatarsPrices[i, 1]);
                }
            }
            if (GlobalInfo.Coins >= price) 
            {
                GlobalInfo.Coins -= price;
                for (int i = 0; i < GlobalInfo.AvatarsOpened.Length / 2; i++)
                {
                    if (GlobalInfo.AvatarsOpened[i, 0] == SelectedAvatar)
                    {
                        GlobalInfo.AvatarsOpened[i, 1] = "Open";
                    }
                }
                ShowAboutAvatar();
            }
        }
        UpdateShadows();
    }
    void ShowAboutAvatar() 
    {
        AvatarName.text = SelectedAvatar;
        bool open = false;
        for (int i = 0; i < GlobalInfo.AvatarsOpened.Length / 2; i++)
        {
            if (GlobalInfo.AvatarsOpened[i, 0] == SelectedAvatar)
            {
                if(GlobalInfo.AvatarsOpened[i, 1] == "Open") open = true; 
            }
        }
        for (int i = 0; i < GlobalInfo.AvatarsDescriptions.Length / 2; i++)
        {
            if (GlobalInfo.AvatarsDescriptions[i,0] == SelectedAvatar) 
            {
                AvatarFlavor.text = GlobalInfo.AvatarsDescriptions[i, 1];
            }
        }
        for (int i = 0; i < GlobalInfo.AvatarsEffects.Length / 2; i++)
        {
            if (GlobalInfo.AvatarsEffects[i, 0] == SelectedAvatar)
            {
                AvatarEffects.text = GlobalInfo.AvatarsEffects[i, 1];
            }
        }
        if (GlobalInfo.SelectedAvatar == SelectedAvatar) 
        {
            ApplyButton.text = "Apply";
            ApplyButton.color = Color.red;
        }
        else if (open) 
        {
            ApplyButton.text = "Select";
            ApplyButton.color = Color.white;
        }
        else 
        {
            int price = 0;
            for (int i = 0; i < GlobalInfo.AvatarsPrices.Length / 2; i++)
            {
                if (GlobalInfo.AvatarsPrices[i, 0] == SelectedAvatar)
                {
                    price = Convert.ToInt32(GlobalInfo.AvatarsPrices[i, 1]);
                }
            }
            ApplyButton.text = "Buy for " + price + " coins";
            ApplyButton.color = Color.blue;
        }
    }
    void UpdateShadows() 
    {
        WitchShadow.color = Color.gray;
        if (SelectedAvatar == "Witch") WitchShadow.color = Color.white;
        if (GlobalInfo.SelectedAvatar == "Witch") WitchShadow.color = Color.red;
        HumanShadow.color = Color.gray;
        if (SelectedAvatar == "Human") HumanShadow.color = Color.white;
        if (GlobalInfo.SelectedAvatar == "Human") HumanShadow.color = Color.red;
        DeamonShadow.color = Color.gray;
        if (SelectedAvatar == "Deamon") DeamonShadow.color = Color.white;
        if (GlobalInfo.SelectedAvatar == "Deamon") DeamonShadow.color = Color.red;
        SpiritShadow.color = Color.gray;
        if (SelectedAvatar == "Spirit") SpiritShadow.color = Color.white;
        if (GlobalInfo.SelectedAvatar == "Spirit") SpiritShadow.color = Color.red;
        PumpkinShadow.color = Color.gray;
        if (SelectedAvatar == "Pumpkin") PumpkinShadow.color = Color.white;
        if (GlobalInfo.SelectedAvatar == "Pumpkin") PumpkinShadow.color = Color.red;
    }
}
