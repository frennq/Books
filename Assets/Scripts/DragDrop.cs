using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
   {
        Debug.Log("BeginDrag");
   }

   public void OnEndDrag(PointerEventData eventData)
   {
        Debug.Log("EndDrag");
   }
   
   public void OnPoniterDown(PointerEventData eventData)
   {
        Debug.Log("CLICK");
   }

}
