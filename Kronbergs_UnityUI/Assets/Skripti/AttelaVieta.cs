using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttelaVieta : MonoBehaviour, IDropHandler {
	public GameObject cepuresVieta, cepure;

	public void OnDrop(PointerEventData eventData){
		if (eventData.pointerDrag != null) {
			cepure.SetActive (false);
			cepuresVieta.SetActive (true);
		}
	}
}
