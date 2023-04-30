using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
   private RectTransform rectTransform;
   private Canvas m_Canvas;
   
   private enum DragStates
   {
      drag,
      endDrag
   }

   private DragStates dragState;
   private void Awake()
   {
      rectTransform = GetComponent<RectTransform>();
      m_Canvas = GetComponentInParent<Canvas>();
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
      rectTransform.anchoredPosition += eventData.delta / m_Canvas.scaleFactor;
      dragState = DragStates.drag;
   }
   
   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.CompareTag("Trash"))
      {
         StartCoroutine(KillCreature());
      }
   }

   private IEnumerator KillCreature()
   {
      transform.GetComponent<Animator>().enabled = true;
      MonsterDragManager.Instance.monsterCount -= 1;
      Debug.Log(MonsterDragManager.Instance.monsterCount );
      yield return new WaitForSeconds(1);
      Destroy(gameObject);

   }
}
