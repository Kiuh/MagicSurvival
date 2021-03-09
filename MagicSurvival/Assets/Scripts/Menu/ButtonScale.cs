using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScale : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    float min_scale = 1f;
    [SerializeField]
    float max_scale = 1.2f;
    [SerializeField]
    float time = 1f;
    [SerializeField]
    RectTransform text;
    [SerializeField]
    bool over = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        over = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        over = false;
    }

    private void Start()
    {
        text = this.GetComponent<RectTransform>();
    }
    void Update()
    {
        if (over) text.localScale = Vector3.Lerp(new Vector3(min_scale, min_scale,1), new Vector3(max_scale, max_scale, 1), time);
        else text.localScale = Vector3.Lerp(new Vector3(max_scale, max_scale, 1), new Vector3(min_scale, min_scale, 1), time);
    }
    
}
