using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler,IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(eventData.pointerDrag == null)
        {
            return;
        }

        Draggable draggable = eventData.pointerDrag.GetComponent<Draggable>();
        if(draggable != null)
        {
            draggable.placeholderParent = this.transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
         if(eventData.pointerDrag == null)
        {
            return;
        }

        Draggable draggable = eventData.pointerDrag.GetComponent<Draggable>();
        if(draggable != null && draggable.placeholderParent == this.transform)
        {
            draggable.placeholderParent = draggable.parentToReturnTo;
        }
    }


    public void OnDrop(PointerEventData eventData)
    {
            //When new card is dropped in lane check if space for card.
            
        Debug.Log(eventData.pointerDrag.name + " Was Dropped On " + gameObject.name);

        Draggable draggable = eventData.pointerDrag.GetComponent<Draggable>();
        if(draggable != null)
        {
            draggable.placeholderParent = this.transform;
            draggable.parentToReturnTo = this.transform;
        }
    }
}
