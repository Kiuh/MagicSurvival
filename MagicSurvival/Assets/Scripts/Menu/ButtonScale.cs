using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScale : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    public float min_scale = 1f;
    [SerializeField]
    public float max_scale = 1.2f;
    [SerializeField]
    float time = 1f;
    [SerializeField]
    RectTransform rect;
    [SerializeField]
    bool over = false;
    [SerializeField]
    public bool active = true;

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
        rect = this.GetComponent<RectTransform>();
    }
    void Update()
    {
        if (active)
        {
            if (over) rect.localScale = Vector3.Lerp(new Vector3(min_scale, min_scale, 1), new Vector3(max_scale, max_scale, 1), time);
            else rect.localScale = Vector3.Lerp(new Vector3(max_scale, max_scale, 1), new Vector3(min_scale, min_scale, 1), time);
        }
    }
    
}
