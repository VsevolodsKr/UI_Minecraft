using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluMainisana : MonoBehaviour{
    public Sprite[] atteluMasivs;
    public GameObject mainigaisAttels;
    public void izkritosais(int index){
        if (index == 0)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        if (index == 1)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        if (index == 2)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2]; 
    }
}