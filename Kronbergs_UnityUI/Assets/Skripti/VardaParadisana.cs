using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VardaParadisana : MonoBehaviour {
    private string teksts;
    private string vecums;
    public GameObject VardsLauks;
    public GameObject SkaitlaLauks;
    public GameObject tekstaAttelosana;
    public void uzglabatTekstu(){
        teksts = VardsLauks.GetComponent<Text>().text;
        vecums = SkaitlaLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Tas ir " + teksts.ToUpper() + ", viņam ir " + vecums.ToUpper() + " gadi!";
    }
}
