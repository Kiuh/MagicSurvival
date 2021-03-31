using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Net.Http.Headers;
using System;

public class ClassesGridManager : MonoBehaviour
{
    [SerializeField]
    GameObject parent;
    [SerializeField]
    string SceneName = "SelectLevel";
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
    public string ChoosedClass = "None";
    [SerializeField]
    List<ChoseClassItemScript> ccis;
    [SerializeField]
    GameObject ButtonSelect;
    Text text;
    ButtonScale bs;
    void Awake()
    {
        text = ButtonSelect.GetComponent<Text>();
        bs = ButtonSelect.GetComponent<ButtonScale>();
        sprites = Resources.LoadAll<Sprite>("MagesIcons");
        rect = this.GetComponent<RectTransform>();
        gridLayout = this.GetComponent<GridLayoutGroup>();
        ex_image = example.GetComponentInChildren<Image>();
        rect_child = example.GetComponentInChildren<RectTransform>();
        example.SetActive(true);
    }
    private void Start()
    {
        cell_width = rect.sizeDelta.x / 8;
        cell_height = rect.sizeDelta.y / 3;
        gridLayout.cellSize.Set(cell_width, cell_height); 
        //Debug.Log(cell_width + " " + cell_height + " " + gridLayout.cellSize);
        cell_width = (rect.sizeDelta.x * 0.9f) / 8;
        cell_height = (rect.sizeDelta.y * 0.9f) / 3;
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
            ccis.Add(gameObject.GetComponent<ChoseClassItemScript>());
            ccis[ccis.Count - 1].ClassName = ex_image.sprite.name;
            ccis[ccis.Count - 1].Check();
        }
        example.SetActive(false);
    }
    void Update()
    {
        if (ChoosedClass != "None")
        {
            text.color = new Color(1f, 0.4352941f, 0.2313726f);
            bs.min_scale = 1.1f;
            bs.max_scale = 1.2f;
        }
        else
        {
            text.color = new Color(0.3584906f, 0.3584906f, 0.3584906f);
            bs.min_scale = 1f;
            bs.max_scale = 1.1f;
        }
    }
    public void SelectButtonClick() 
    {
        if (ChoosedClass != "None") SceneManager.LoadScene(SceneName);
    }
    public void CloseButtonClick() 
    {
        GameObject.Destroy(parent);
    }
    public void Clear() 
    {
        foreach (ChoseClassItemScript item in ccis)
        {
            item.ToNormal();
        }
    }
}
