using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Nonemsana2 : MonoBehaviour, IDropHandler {
	public GameObject prieksautuVieta, klase;
	public GameObject[] prieksautes;
	Vector3 prieksautuVietasPoz;
	void Start(){
		prieksautuVietasPoz = new Vector3(prieksautuVieta.transform.position.x, prieksautuVieta.transform.position.y);
	}
	public void OnDrop(PointerEventData eventData){
		GameObject objekts = eventData.pointerDrag;
		if(prieksautuVieta.transform.position.x < klase.transform.position.x || prieksautuVieta.transform.position.x > klase.transform.position.x || prieksautuVieta.transform.position.y < klase.transform.position.y || prieksautuVieta.transform.position.y > klase.transform.position.y){
			prieksautuVieta.transform.position = new Vector3(prieksautuVietasPoz.x, prieksautuVietasPoz.y, 0);
			if (objekts.GetComponent<Image> ().sprite.name == "ArmorOnCharacter") {
				prieksautes[3].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "GoldenArmorOnCharacter") {
				prieksautes[2].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "IronArmorOnCharacter") {
				prieksautes[1].SetActive (true);
			} else if (objekts.GetComponent<Image> ().sprite.name == "LeatherArmorOnCharacter"){
				prieksautes[0].SetActive (true);
			} 
			prieksautuVieta.SetActive (false);
		}
	}
}