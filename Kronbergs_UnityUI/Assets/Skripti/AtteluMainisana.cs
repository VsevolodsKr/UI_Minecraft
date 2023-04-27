using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluMainisana : MonoBehaviour{
    public Sprite[] atteluMasivs;
    public GameObject mainigaisAttels;
    public GameObject tekstaLauks;
    public GameObject helmet;
    public GameObject armor;
    public GameObject trousers;
    public GameObject shoes;
    public Sprite fons1;
    public Sprite fons2;
	public GameObject fonaMaina;
    public Slider slideraIzmers1;
    public Slider slideraIzmers2;
    private RectTransform imageRectTransform, helmetTransform, armorTransform, trousersTransform, shoesTransform;
    void Start(){
        imageRectTransform = mainigaisAttels.GetComponent<RectTransform>();
        helmetTransform = helmet.GetComponent<RectTransform>();
        armorTransform = armor.GetComponent<RectTransform>();
        trousersTransform = trousers.GetComponent<RectTransform>();
        shoesTransform = shoes.GetComponent<RectTransform>();
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
    public void HelmetAttels(bool vertiba){
        helmet.SetActive(vertiba);
    }
    public void ArmorAttels(bool vertiba){
        armor.SetActive(vertiba);
    }
    public void TrousersAttels(bool vertiba){
        trousers.SetActive(vertiba);
    }
    public void ShoesAttels(bool vertiba){
        shoes.SetActive(vertiba);
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
        helmet.transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);
        armor.transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);
        trousers.transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);
        shoes.transform.localScale = new Vector2(1f * pasreizejaisIzmers, 1f * pasreizejaisIzmers);
    }
    public void mainitPlatumu(){
        imageRectTransform.sizeDelta = new Vector2(slideraIzmers2.value, imageRectTransform.sizeDelta.y);
        helmetTransform.sizeDelta = new Vector2(slideraIzmers2.value, helmetTransform.sizeDelta.y);
        armorTransform.sizeDelta = new Vector2(slideraIzmers2.value, armorTransform.sizeDelta.y);
        trousersTransform.sizeDelta = new Vector2(slideraIzmers2.value, trousersTransform.sizeDelta.y);
        shoesTransform.sizeDelta = new Vector2(slideraIzmers2.value, shoesTransform.sizeDelta.y);
    }
}