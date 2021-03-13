using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectChooseClass : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    string SceneName = "SelectLevel";
    [SerializeField]
    ClassesGridManager cgm;
    Text text;
    ButtonScale bs;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(cgm.ChoosedClass != "None") SceneManager.LoadScene(SceneName);
    }

    void Start()
    {
        text = this.GetComponent<Text>();
        bs = this.GetComponent<ButtonScale>();
        
    }

    void Update()
    {
        if (cgm.ChoosedClass != "None") 
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
}
