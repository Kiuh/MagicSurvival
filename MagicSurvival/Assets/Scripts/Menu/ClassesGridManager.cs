using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class ClassesGridManager : MonoBehaviour
{
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
    string ChoosedClass = "None";
    void Awake()
    {
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
        gridLayout.cellSize.Set(cell_width, cell_height); //Debug.Log(cell_width + " " + cell_height + " " + gridLayout.cellSize);
        cell_width = (rect.sizeDelta.x * 0.9f) / 8;
        cell_height = (rect.sizeDelta.y * 0.9f) / 3;
        foreach (Sprite item in sprites)
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
            Instantiate(example, this.transform);
        }
        example.SetActive(false);
    }
}
