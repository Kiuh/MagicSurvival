using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    GameObject gameObject;
    [SerializeField]
    GameObject parent;
    public void Start()
    {
        gameObject = Resources.Load("SelectClass") as GameObject;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Instantiate(gameObject, parent.transform);
    }
}
