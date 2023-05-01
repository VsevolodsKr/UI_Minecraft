using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Nonemsana4 : MonoBehaviour, IDropHandler {
	public GameObject zabakiVieta, klase;
	public GameObject[] zabaki;
	Vector3 zabakiVietasPoz;
	void Start(){
		zabakiVietasPoz = new Vector3(zabakiVieta.transform.position.x, zabakiVieta.transform.position.y);
	}
	public void OnDrop(PointerEventData eventData){
		GameObject objekts = eventData.pointerDrag;
		if(zabakiVieta.transform.position.x < klase.transform.position.x || zabakiVieta.transform.position.x > klase.transform.position.x || zabakiVieta.transform.position.y < klase.transform.position.y || zabakiVieta.transform.position.y > klase.transform.position.y){
			zabakiVieta.transform.position = new Vector3(zabakiVietasPoz.x, zabakiVietasPoz.y, 0);
			if (objekts.GetComponent<Image> ().sprite.name == "ShoesOnCharacter") {
				zabaki[3].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "GoldenShoesOnCharacter") {
				zabaki[2].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "IronShoesOnCharacter") {
				zabaki[1].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "LeatherShoesOnCharacter"){
				zabaki[0].SetActive (true);
			} 
			zabakiVieta.SetActive (false);
		}
	}
}