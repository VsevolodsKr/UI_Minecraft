using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Nonemsana : MonoBehaviour, IDropHandler {
	public GameObject cepuresVieta, klase;
	public GameObject[] cepures;
	Vector3 cepuresVietasPoz;
	void Start(){
		cepuresVietasPoz = new Vector3(cepuresVieta.transform.position.x, cepuresVieta.transform.position.y);
	}
	public void OnDrop(PointerEventData eventData){
		GameObject objekts = eventData.pointerDrag;
		if(cepuresVieta.transform.position.x < klase.transform.position.x || cepuresVieta.transform.position.x > klase.transform.position.x || cepuresVieta.transform.position.y < klase.transform.position.y || cepuresVieta.transform.position.y > klase.transform.position.y){
			cepuresVieta.transform.position = new Vector3(cepuresVietasPoz.x, cepuresVietasPoz.y, 0);
			if (objekts.GetComponent<Image> ().sprite.name == "HelmetOnCharacter") {
				cepures[3].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "GoldenHelmetOnCharacter") {
				cepures[2].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "IronHelmetOnCharacter") {
				cepures[1].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "LeatherHelmetOnCharacter"){
				cepures[0].SetActive (true);
			} 
			cepuresVieta.SetActive (false);
		}
}
}