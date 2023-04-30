using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjektuParvietosana : MonoBehaviour {
	Transform parentAfterDrag;
    public Slider slideris1, slideris2;
	public GameObject cepureVieta, prieksautsVieta, biksesVieta, zabakiVieta;
	public GameObject[]  cepure, prieksauts, bikses, zabaki;
	Vector3[] cepureInitialPos = null, prieksautsInitialPos = null, biksesInitialPos = null, zabakiInitialPos = null;
    private float distancijaCepure, distancijaPrieksauts, distancijaBikses, distancijaZabaki, platums;
	void Start() {
		cepureInitialPos = new Vector3[cepure.Length];
		prieksautsInitialPos = new Vector3[prieksauts.Length];
		biksesInitialPos = new Vector3[bikses.Length];
		zabakiInitialPos = new Vector3[zabaki.Length];
		for (int i = 0; i < cepure.Length; i++) {
			cepureInitialPos[i] = cepure[i].transform.position;
		}
		for (int i = 0; i < prieksauts.Length; i++) {
			prieksautsInitialPos[i] = prieksauts[i].transform.position;
		}
		for (int i = 0; i < bikses.Length; i++) {
			biksesInitialPos[i] = bikses[i].transform.position;
		}
		for (int i = 0; i < zabaki.Length; i++) {
			zabakiInitialPos[i] = zabaki[i].transform.position;
		}
    }
	public void dragCepure(int index) {
		cepure[index].transform.position = Input.mousePosition;
    }
	public void dragPrieksauts(int index){
		prieksauts[index].transform.position = Input.mousePosition;
    }
	public void dragBikses(int index){
		bikses[index].transform.position = Input.mousePosition;
    }
	public void dragZabaki(int index){
		zabaki[index].transform.position = Input.mousePosition;
    }
	public void dropCepure(int index) {
		distancijaCepure = Vector3.Distance(cepure[index].transform.position, cepureVieta.transform.position);
		if (distancijaCepure < 20){
			cepure[index].transform.position = cepureVieta.transform.position;      
        }
        else {
			cepure[index].transform.position = cepureInitialPos[index];
        }
    }
	public void dropPrieksauts(int index){
		distancijaPrieksauts = Vector3.Distance(prieksauts[index].transform.position, prieksautsVieta.transform.position);
		if (distancijaPrieksauts < 20)
        {
			prieksauts[index].transform.position = prieksautsVieta.transform.position;
        }
        else
        {
			prieksauts[index].transform.position = prieksautsInitialPos[index];
        }
    }
	public void dropBikses(int index){
		distancijaBikses = Vector3.Distance(bikses[index].transform.position, biksesVieta.transform.position);
		if (distancijaBikses < 20)
        {
			bikses[index].transform.position = biksesVieta.transform.position;
        }
        else
        {
			bikses[index].transform.position = biksesInitialPos[index];
        }
    }
	public void dropZabaki(int index){
		distancijaZabaki = Vector3.Distance(zabaki[index].transform.position, zabakiVieta.transform.position);
		if (distancijaBikses < 20)
        {
			zabaki[index].transform.position = zabakiVieta.transform.position;
        }
        else
        {
			zabaki[index].transform.position = zabakiInitialPos[index];
        }
    }
}