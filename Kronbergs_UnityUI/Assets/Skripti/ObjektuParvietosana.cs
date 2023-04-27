using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjektuParvietosana : MonoBehaviour {
    public Slider slideris1, slideris2;
	public GameObject cepure, prieksauts, bikses, zabaki, cepureVieta, prieksautsVieta, biksesVieta, zabakiVieta;
	Vector2 cepureInitialPos, prieksautsInitialPos, biksesInitialPos, zabakiInitialPos;
    private float distancija, platums;
	void Start() {
        cepureInitialPos = cepure.transform.position;
        prieksautsInitialPos = prieksauts.transform.position;
        biksesInitialPos = bikses.transform.position;
        zabakiInitialPos = zabaki.transform.position;
    }
	public void kustinatCepure() {
		cepure.transform.position = Input.mousePosition;
    }
    public void kustinatPrieksauts(){
        prieksauts.transform.position = Input.mousePosition;
    }
    public void kustinatBikses(){
        bikses.transform.position = Input.mousePosition;
    }
    public void kustinatZabaki(){
        zabaki.transform.position = Input.mousePosition;
    }
    public void dropCepure() {
        distancija = Vector3.Distance(cepure.transform.position, cepureVieta.transform.position);
        if (distancija < 20){
            cepure.transform.position = cepureVieta.transform.position;      
        }
        else {
            cepure.transform.position = cepureInitialPos;
        }
    }
    public void dropPrieksauts(){
        distancija = Vector3.Distance(prieksauts.transform.position, prieksautsVieta.transform.position);
        if (distancija < 20)
        {
            prieksauts.transform.position = prieksautsVieta.transform.position;
        }
        else
        {
            prieksauts.transform.position = prieksautsInitialPos;
        }
    }
    public void dropBikses(){
        distancija = Vector3.Distance(bikses.transform.position, bikses.transform.position);
        if (distancija < 20)
        {
            bikses.transform.position = biksesVieta.transform.position;
        }
        else
        {
            bikses.transform.position = biksesInitialPos;
        }
    }
    public void dropZabaki(){
        distancija = Vector3.Distance(zabaki.transform.position, zabakiVieta.transform.position);
        if (distancija < 20)
        {
            zabaki.transform.position = zabakiVieta.transform.position;
        }
        else
        {
            zabaki.transform.position = zabakiInitialPos;
        }
    }
}