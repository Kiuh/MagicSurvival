using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonExit : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        //Maybe save progress
        Application.Quit();
    }
}
