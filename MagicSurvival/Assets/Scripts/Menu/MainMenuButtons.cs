using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField]
    public Canvas canvas;
    GameObject SelectClass;
    GameObject ChooseAvatar;
    private void Start()
    {
        SelectClass = Resources.Load("SelectClass") as GameObject;
        ChooseAvatar = Resources.Load("ChooseAvatar") as GameObject;
    }
    public void ButtonStart() 
    {
        GameObject.Instantiate(SelectClass, canvas.transform);
    }
    public void ShooseAvatar()
    {
        GameObject.Instantiate(ChooseAvatar, canvas.transform);
    }
    public void EnterLaboratory() 
    {
    
    }
    public void Options()
    {

    }
    public void OpenReserchBook() 
    {
        
    }
    public void Exit() 
    {
        // Maybe save progress
        Application.Quit();
    }
}
