using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AttelaVieta : MonoBehaviour, IDropHandler {
	public GameObject cepuresVieta, prieksautuVieta, biksesVieta, zabakuVieta;
	public GameObject[] cepures, prieksauti, bikses, zabaki;
	public Sprite[] Helmets, Armors, Trousers, Shoes;
	public Slider garums, platums;
	Vector3[] pozicijas = null;
	void Start(){
		pozicijas[0] = new Vector3 (cepures[0].transform.position.x, cepures[0].transform.position.y);
		pozicijas[1] = new Vector3 (cepures[1].transform.position.x, cepures[1].transform.position.y);
		pozicijas[2] = new Vector3 (cepures[2].transform.position.x, cepures[2].transform.position.y);
		pozicijas[3] = new Vector3 (cepures[3].transform.position.x, cepures[3].transform.position.y);
		pozicijas[4] = new Vector3 (prieksauti[0].transform.position.x, prieksauti[0].transform.position.y);
		pozicijas[5] = new Vector3 (prieksauti[1].transform.position.x, prieksauti[1].transform.position.y);
		pozicijas[6] = new Vector3 (prieksauti[2].transform.position.x, prieksauti[2].transform.position.y);
		pozicijas[7] = new Vector3 (prieksauti[3].transform.position.x, prieksauti[3].transform.position.y);
		pozicijas[8] = new Vector3 (bikses[0].transform.position.x, bikses[0].transform.position.y);
		pozicijas[9] = new Vector3 (bikses[1].transform.position.x, bikses[1].transform.position.y);
		pozicijas[10] = new Vector3 (bikses[2].transform.position.x, bikses[2].transform.position.y);
		pozicijas[11] = new Vector3 (bikses[3].transform.position.x, bikses[3].transform.position.y);
		pozicijas[12] = new Vector3 (zabaki[0].transform.position.x, zabaki[0].transform.position.y);
		pozicijas[13] = new Vector3 (zabaki[1].transform.position.x, zabaki[1].transform.position.y);
		pozicijas[14] = new Vector3 (zabaki[2].transform.position.x, zabaki[2].transform.position.y);
		pozicijas[15] = new Vector3 (zabaki[3].transform.position.x, zabaki[3].transform.position.y);
	}

	public void OnDrop(PointerEventData eventData){
		GameObject objekts = eventData.pointerDrag;
		if (objekts.CompareTag("cepure4")) {
			if (eventData.pointerDrag != null) {
				cepuresVieta.GetComponent<Image> ().sprite = Helmets[3];
				cepures[3].SetActive (false);
				cepuresVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				cepures[3].transform.position = new Vector3 (pozicijas[3].x, pozicijas[3].y, 0);
			}
		}
		else if (objekts.CompareTag("cepure3")) {
			if (eventData.pointerDrag != null) {
				cepuresVieta.GetComponent<Image> ().sprite = Helmets[2];
				cepures[2].SetActive (false);
				cepuresVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				cepures[2].transform.position = new Vector3 (pozicijas[2].x, pozicijas[2].y, 0);
			}
		}
		else if (objekts.CompareTag("cepure2")) {
			if (eventData.pointerDrag != null) {
				cepuresVieta.GetComponent<Image> ().sprite = Helmets[1];
				cepures[1].SetActive (false);
				cepuresVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				cepures[1].transform.position = new Vector3 (pozicijas[1].x, pozicijas[1].y, 0);
			}
		}
		else if (objekts.CompareTag("cepure1")) {
			if (eventData.pointerDrag != null) {
				cepuresVieta.GetComponent<Image> ().sprite = Helmets[0];
				cepures[0].SetActive (false);
				cepuresVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				cepures[0].transform.position = new Vector3 (pozicijas[0].x, pozicijas[0].y, 0);
			}
		}
		else if (objekts.CompareTag("prieksauts4")) {
			if (eventData.pointerDrag != null) {
				prieksautuVieta.GetComponent<Image> ().sprite = Armors[3];
				prieksauti[3].SetActive (false);
				prieksautuVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				prieksauti[3].transform.position = new Vector3 (pozicijas[7].x, pozicijas[7].y, 0);
			}
		}
		else if (objekts.CompareTag("prieksauts3")) {
			if (eventData.pointerDrag != null) {
				prieksautuVieta.GetComponent<Image> ().sprite = Armors[2];
				prieksauti[2].SetActive (false);
				prieksautuVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				prieksauti[2].transform.position = new Vector3 (pozicijas[6].x, pozicijas[6].y, 0);
			}
		}
		else if (objekts.CompareTag("prieksauts2")) {
			if (eventData.pointerDrag != null) {
				prieksautuVieta.GetComponent<Image> ().sprite = Armors[1];
				prieksauti[1].SetActive (false);
				prieksautuVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				prieksauti[1].transform.position = new Vector3 (pozicijas[5].x, pozicijas[5].y, 0);
			}
		}
		else if (objekts.CompareTag("prieksauts1")) {
			if (eventData.pointerDrag != null) {
				prieksautuVieta.GetComponent<Image> ().sprite = Armors[0];
				prieksauti[0].SetActive (false);
				prieksautuVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				prieksauti[0].transform.position = new Vector3 (pozicijas[4].x, pozicijas[4].y, 0);
			}
		}
		else if (objekts.CompareTag("bikses4")) {
			if (eventData.pointerDrag != null) {
				biksesVieta.GetComponent<Image> ().sprite = Trousers[3];
				bikses[3].SetActive (false);
				biksesVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				bikses[3].transform.position = new Vector3 (pozicijas[11].x, pozicijas[11].y, 0);
			}
		}
		else if (objekts.CompareTag("bikses3")) {
			if (eventData.pointerDrag != null) {
				biksesVieta.GetComponent<Image> ().sprite = Trousers[2];
				bikses[2].SetActive (false);
				biksesVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				bikses[2].transform.position = new Vector3 (pozicijas[10].x, pozicijas[10].y, 0);
			}
		}
		else if (objekts.CompareTag("bikses2")) {
			if (eventData.pointerDrag != null) {
				biksesVieta.GetComponent<Image> ().sprite = Trousers[1];
				bikses[1].SetActive (false);
				biksesVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				bikses[1].transform.position = new Vector3 (pozicijas[9].x, pozicijas[9].y, 0);
			}
		}
		else if (objekts.CompareTag("bikses1")) {
			if (eventData.pointerDrag != null) {
				biksesVieta.GetComponent<Image> ().sprite = Trousers[0];
				bikses[0].SetActive (false);
				biksesVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				bikses[0].transform.position = new Vector3 (pozicijas[8].x, pozicijas[8].y, 0);
			}
		}
		else if (objekts.CompareTag("zabaki4")) {
			if (eventData.pointerDrag != null) {
				zabakuVieta.GetComponent<Image> ().sprite = Shoes[3];
				zabaki[3].SetActive (false);
				zabakuVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				zabaki[3].transform.position = new Vector3 (pozicijas[15].x, pozicijas[15].y, 0);
			}
		}
		else if (objekts.CompareTag("zabaki3")) {
			if (eventData.pointerDrag != null) {
				zabakuVieta.GetComponent<Image> ().sprite = Shoes[2];
				zabaki[2].SetActive (false);
				zabakuVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				zabaki[2].transform.position = new Vector3 (pozicijas[14].x, pozicijas[14].y, 0);
			}
		}
		else if (objekts.CompareTag("zabaki2")) {
			if (eventData.pointerDrag != null) {
				zabakuVieta.GetComponent<Image> ().sprite = Shoes[1];
				zabaki[1].SetActive (false);
				zabakuVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				zabaki[1].transform.position = new Vector3 (pozicijas[13].x, pozicijas[13].y, 0);
			}
		}
		else if (objekts.CompareTag("zabaki1")) {
			if (eventData.pointerDrag != null) {
				zabakuVieta.GetComponent<Image> ().sprite = Shoes[0];
				zabaki[0].SetActive (false);
				zabakuVieta.SetActive (true);
				garums.GetComponent<Slider> ().interactable = false;
				platums.GetComponent<Slider> ().interactable = false;
			} else {
				zabaki[0].transform.position = new Vector3 (pozicijas[12].x, pozicijas[12].y, 0);
			}
		}
	}
}
