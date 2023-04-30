using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Nonemsana : MonoBehaviour, IDropHandler {
	public GameObject cepure, cepuresVieta, klase;
	public void OnDrop(PointerEventData eventData){
		if(cepuresVieta.transform.position.x < klase.transform.position.x || cepuresVieta.transform.position.x > klase.transform.position.x || cepuresVieta.transform.position.y < klase.transform.position.y || cepuresVieta.transform.position.y < klase.transform.position.y){
			cepuresVieta.SetActive (false);
			cepure.SetActive (true);
		}
}
}