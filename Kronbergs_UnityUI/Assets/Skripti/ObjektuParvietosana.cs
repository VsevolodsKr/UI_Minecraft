using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IDragHandler{
	private RectTransform transformacijasLogs;
	public Canvas kanva;
	private void Awake(){
		transformacijasLogs = GetComponent<RectTransform> ();
	}
	public void OnDrag(PointerEventData notikums){
		Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		mousePosition.x = Mathf.Clamp(mousePosition.x, 0+transformacijasLogs.rect.width / 2, Screen.width - transformacijasLogs.rect.width / 2);
		mousePosition.y = Mathf.Clamp(mousePosition.y, 0+transformacijasLogs.rect.height / 2, Screen.height - transformacijasLogs.rect.height / 2);
		transform.position = mousePosition;
	}
}
