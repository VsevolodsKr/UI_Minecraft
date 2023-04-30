using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektaParvietosana : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler  {
	[SerializeField] private Canvas kanva;
	private RectTransform rectTransform;
	private CanvasGroup kanvuGrupa;
	private void Awake(){
		rectTransform = GetComponent<RectTransform>();
		kanvuGrupa = GetComponent<CanvasGroup> ();
	}
	public void OnBeginDrag(PointerEventData eventData){
		kanvuGrupa.blocksRaycasts = false;
	}
	public void OnDrag(PointerEventData eventData){
		rectTransform.anchoredPosition += eventData.delta / kanva.scaleFactor;
	}
	public void OnEndDrag(PointerEventData eventData){
		kanvuGrupa.blocksRaycasts = true;
	}
}
