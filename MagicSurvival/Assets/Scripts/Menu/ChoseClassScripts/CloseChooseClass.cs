using UnityEngine;
using UnityEngine.EventSystems;

public class CloseChooseClass : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    GameObject go;
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject.Destroy(go);
    }
}
