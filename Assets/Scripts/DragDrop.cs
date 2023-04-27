using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

     private RectTransform rectTrans;
     public Canvas myCanvas;

     void Start()
     {
          rectTrans = GetComponent<RectTransform>();
     }


    public void OnBeginDrag(PointerEventData eventData)
   {
        Debug.Log("BeginDrag");
   }

   public void OnDrag(PointerEventData eventData)
   {
        //Debug.Log("OnDrag");
        rectTrans.anchoredPosition += eventData.delta / myCanvas.scaleFactor;
   }

   public void OnEndDrag(PointerEventData eventData)
   {
        Debug.Log("EndDrag");
   }
   
   public void OnPointerDown(PointerEventData eventData)
   {
        Debug.Log("CLICK");
   }

}
