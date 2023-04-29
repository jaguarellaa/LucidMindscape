using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
   private RectTransform rectTransform;
   
   private enum DragStates
   {
      drag,
      endDrag
   }

   private DragStates dragState;
   private void Awake()
   {
      rectTransform = GetComponent<RectTransform>();
   }

   public void OnPointerDown(PointerEventData eventData)
   {
      Debug.Log("OnPointerDown");
   }

   public void OnBeginDrag(PointerEventData eventData)
   {
      Debug.Log("OnBeginDrag");
   }

   public void OnEndDrag(PointerEventData eventData)
   {
      Debug.Log("OnEndDrag");
      dragState = DragStates.endDrag;
   }

   public void OnDrag(PointerEventData eventData)
   {
      Debug.Log("OnDrag");
      rectTransform.anchoredPosition += eventData.delta;
      dragState = DragStates.drag;
   }
   
   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.CompareTag("Trash"))
      {
         Debug.Log("It's touched");
         Destroy(gameObject);
         
      }
   }
}
