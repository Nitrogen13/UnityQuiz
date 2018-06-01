using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler {
    public GameObject Item
    {
        get
        {
            if(transform.childCount > 0)
                return transform.GetChild(0).gameObject;
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!Item)
            DragHandler.item.transform.SetParent(transform);
    }
}
