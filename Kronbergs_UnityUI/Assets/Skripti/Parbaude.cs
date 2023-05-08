using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parbaude : MonoBehaviour {

	public GameObject cepuresVieta, prieksautuVieta, biksesVieta, zabakiVieta;
	public Slider garums, platums;
	void Update () {
		if (cepuresVieta.activeSelf == false && prieksautuVieta.activeSelf == false && biksesVieta.activeSelf == false && zabakiVieta.activeSelf == false) {
			garums.GetComponent<Slider> ().interactable = true;
			platums.GetComponent<Slider> ().interactable = true;
		}
	}
}
