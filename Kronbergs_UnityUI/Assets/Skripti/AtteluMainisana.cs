using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluMainisana : MonoBehaviour{
    public Sprite[] atteluMasivs;
    public GameObject mainigaisAttels;
    public GameObject tekstaLauks;
    public GameObject[] helmets;
    public GameObject[] armors;
    public GameObject[] trousers;
    public GameObject[] shoes;
    public Sprite fons1;
    public Sprite fons2;
	public GameObject fonaMaina;
    public Slider slideraIzmers1;
    public Slider slideraIzmers2;
	private bool palidzBool = false;
    private RectTransform imageRectTransform;
	private RectTransform[] helmetTransform = null, armorTransform = null, trousersTransform = null, shoesTransform = null;
    void Start(){
		helmetTransform = new RectTransform[helmets.Length];
		armorTransform = new RectTransform[armors.Length];
		trousersTransform = new RectTransform[trousers.Length];
		shoesTransform = new RectTransform[shoes.Length];
        imageRectTransform = mainigaisAttels.GetComponent<RectTransform>();
		for(int i = 0; i < armors.Length; i++) {
			armorTransform[i] = armors[i].GetComponent<RectTransform> ();
		}
		for(int i = 0; i < helmets.Length; i++) {
			helmetTransform[i] = helmets[i].GetComponent<RectTransform> ();
		}
		for(int i = 0; i <  trousers.Length; i++) {
			trousersTransform[i] = trousers[i].GetComponent<RectTransform> ();
		}
		for(int i = 0; i < shoes.Length; i++) {
			shoesTransform[i] = helmets[i].GetComponent<RectTransform> ();
		}
		Helmets(palidzBool);
		Armors(palidzBool);
		Leggins(palidzBool);
		Shoes(palidzBool);
    }
    public void izkritosais(int index){
        if (index == 0){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
            tekstaLauks.GetComponent<Text>().text = "Es esmu Stīvs! \n \nStīvs tiek prezentēts kā cilvēka raksturs ar bloķētu izskatu, kas atbilst Minecraft estētiskajam un mākslas stilam. Viņa vārds radās kā Persson joks, un tas tika apstiprināts kā viņa oficiālais vārds Minecraft pamatiežu izdevumā.  Stīva seja sastāv no astoņu līdz astoņu pikseļu attēla, ko parasti rotā kaza.Viņš valkā gaiši zilu topu, zilu bikšu pāri un kurpes."; 
        }
        if (index == 1){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
            tekstaLauks.GetComponent<Text>().text = "Es esmu Alekss! \n \nAlekss ir sievietes parādošs, izdomāts varonis, kuru varat izvēlēties spēlēt kā papildus Stīvam.Jūs varat izvēlēties spēlēt kā Alekss, izmantojot savu ģērbtuvi galvenajā izvēlnē. Alekss un Stīvs (Minecraft) Alekss patiesībā nemaz tik ļoti neatšķiras no Stīva, izņemot apģērba maiņu un to, ka Aleksam ir spilgti oranži mati.";
        }
        if (index == 2){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
            tekstaLauks.GetComponent<Text>().text = "ghEghgEhgE.....Smadzenes!";
        }
     }
	public void Helmets(bool vertiba){
		foreach (GameObject obj in helmets) {
			obj.SetActive(vertiba);
		}
	}
	public void Armors(bool vertiba){
		foreach (GameObject obj in armors) {
			obj.SetActive(vertiba);
		}
	}
	public void Leggins(bool vertiba){
		foreach (GameObject obj in trousers) {
			obj.SetActive(vertiba);
		}
	}
	public void Shoes(bool vertiba){
		foreach (GameObject obj in shoes) {
			obj.SetActive(vertiba);
		}
	}
    
    public void diena() { 
		fonaMaina.GetComponent<Image> ().sprite = fons1;
   }
	public void nakts() { 
		fonaMaina.GetComponent<Image> ().sprite = fons2;
	}
    public void mainitGarumu(){
        float pasreizejaisIzmers = slideraIzmers1.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);
		for (int i = 0; i < helmets.Length; i++) {
			helmets[i].transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);
		}
		for (int i = 0; i < armors.Length; i++) {
			armors[i].transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);
		}
		for (int i = 0; i < trousers.Length; i++) {
			trousers[i].transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);
		}
		for (int i = 0; i < shoes.Length; i++) {
			shoes[i].transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);
		}
    }
    public void mainitPlatumu(){
        imageRectTransform.sizeDelta = new Vector2(slideraIzmers2.value, imageRectTransform.sizeDelta.y);
		for (int i = 0; i < helmets.Length; i++) {
			helmetTransform[i].sizeDelta = new Vector2(slideraIzmers2.value, imageRectTransform.sizeDelta.y);
		}
		for (int i = 0; i < armors.Length; i++) {
			armorTransform[i].sizeDelta = new Vector2(slideraIzmers2.value, imageRectTransform.sizeDelta.y);
		}
		for (int i = 0; i < trousers.Length; i++) {
			trousersTransform[i].sizeDelta = new Vector2(slideraIzmers2.value, imageRectTransform.sizeDelta.y);
		}
		for (int i = 0; i < shoes.Length; i++) {
			shoesTransform[i].sizeDelta = new Vector2(slideraIzmers2.value, imageRectTransform.sizeDelta.y);
		}
    }
}