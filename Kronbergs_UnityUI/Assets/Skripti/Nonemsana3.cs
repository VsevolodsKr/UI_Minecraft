using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Nonemsana3 : MonoBehaviour, IDropHandler {
	public GameObject biksesVieta, klase;
	public GameObject[] bikses;
	Vector3 biksesVietasPoz;
	void Start(){
		biksesVietasPoz = new Vector3(biksesVieta.transform.position.x, biksesVieta.transform.position.y);
	}
	public void OnDrop(PointerEventData eventData){
		GameObject objekts = eventData.pointerDrag;
		if(biksesVieta.transform.position.x < klase.transform.position.x || biksesVieta.transform.position.x > klase.transform.position.x || biksesVieta.transform.position.y < klase.transform.position.y || biksesVieta.transform.position.y > klase.transform.position.y){
			biksesVieta.transform.position = new Vector3(biksesVietasPoz.x, biksesVietasPoz.y, 0);
			if (objekts.GetComponent<Image> ().sprite.name == "LegginsOnCharacter") {
				bikses[3].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "GoldenLegginsOnCharacter") {
				bikses[2].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "IronLegginsOnCharacter") {
				bikses[1].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "LeatherLegginsOnCharacter"){
				bikses[0].SetActive (true);
			} 
			biksesVieta.SetActive (false);
		}
	}
}