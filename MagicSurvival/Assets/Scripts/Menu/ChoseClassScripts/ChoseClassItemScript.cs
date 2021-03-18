using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChoseClassItemScript : MonoBehaviour, IPointerClickHandler
{
    public string ClassName;
    public ClassesGridManager cgm;
    public bool active = false;
    [SerializeField]
    Text ForClassName;
    [SerializeField]
    Text ForClassDescription;
    [SerializeField]
    Text ForClassMastery;
    RectTransform rect;
    ButtonScale bs;
    Image image;
    [SerializeField]
    bool open = true;
    Color DefaultImageColor = new Color(1, 1, 1, 1);
    private void Start()
    {
        cgm = this.GetComponentInParent<ClassesGridManager>();
        rect = this.GetComponent<RectTransform>();
        bs = this.GetComponent<ButtonScale>();
        image = this.GetComponentInChildren<Image>();
        if (!open) 
        {
            bs.active = false;
            image.color = DefaultImageColor;
        }
    }
    public void Check() 
    {
        for (int i = 0; i < GlobalInfo.MagesMasterProcent.Length / 2; i++)
        {
            if (GlobalInfo.MagesMasterProcent[i, 0] == ClassName)
            {
                if (GlobalInfo.MagesMasterProcent[i, 1] == "100")
                {
                    DefaultImageColor = new Color(1, 0.6716879f, 0.6556604f,1);
                }
                break;
            }
        }
        for (int i = 0; i < GlobalInfo.MagesOpened.Length / 2; i++)
        {
            if (GlobalInfo.MagesOpened[i, 0] == ClassName)
            {
                if (GlobalInfo.MagesOpened[i, 1] != "Open")
                {
                    DefaultImageColor = Color.gray;
                    open = false;
                }
                break;
            }
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (open)
        {
            if (!active)
            {
                cgm.Clear();
                bs.active = false;
                rect.localScale = new Vector3(bs.max_scale, bs.max_scale, 1);
                image.color = new Color(0.7921569f, 0.7882353f, 0.3176471f, 1);
                ForClassName.text = ClassName;
                for (int i = 0; i < GlobalInfo.MagesMasterProcent.Length / 2; i++)
                {
                    if (GlobalInfo.MagesMasterProcent[i, 0] == ClassName)
                    {
                        if (GlobalInfo.MagesMasterProcent[i, 1] == "100")
                        {
                            ForClassMastery.text = "Master";
                        }
                        else
                        {
                            ForClassMastery.text = "Mastery progress: " + GlobalInfo.MagesMasterProcent[i, 1] + "%";
                        }
                        break;
                    }
                    if (i == GlobalInfo.MagesMasterProcent.Length / 2 - 1)
                    {
                        ForClassMastery.text = "Not found";
                    }
                }
                for (int i = 0; i < GlobalInfo.MagesDescriptions.Length / 3; i++)
                {
                    if (GlobalInfo.MagesDescriptions[i, 0] == ClassName)
                    {
                        if (ForClassMastery.text == "Master")
                            ForClassDescription.text = GlobalInfo.MagesDescriptions[i, 2];
                        else 
                            ForClassDescription.text = GlobalInfo.MagesDescriptions[i, 1];
                        break;
                    }
                    if (i == GlobalInfo.MagesDescriptions.Length / 2 - 1)
                    {
                        ForClassDescription.text = "Not found";
                    }
                }
                ForClassName.color = Color.yellow;
                ForClassMastery.color = new Color(1f, 0.4352941f, 0.2313726f, 1);
                ForClassDescription.color = new Color(0.2588235f, 1, 0.2235294f, 1);
                active = true;
                cgm.ChoosedClass = ClassName;
            }
            else
            {
                ToNormal();
                ForClassName.color = new Color(1, 1, 1, 1);
                ForClassMastery.color = new Color(1, 1, 1, 1);
                ForClassDescription.color = new Color(1, 1, 1, 1);
                image.color = DefaultImageColor;
                ForClassName.text = "Class";
                ForClassDescription.text = "Choose Your Class";
                ForClassMastery.text = "";
                cgm.ChoosedClass = "None";
            }
        }
    }

    public void ToNormal() 
    {
        if (active) 
        {
            bs.active = true;
            rect.localScale = new Vector3(bs.min_scale, bs.min_scale, 1);
            image.color = DefaultImageColor;
            active = false;
        }
    }
}
