using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skanas : MonoBehaviour {
	public AudioClip[] skanas;
	public GameObject attels;
	public void OnMouseDown(){
		if(attels.GetComponent<Image>().sprite.name == "Stivs" || attels.GetComponent<Image>().sprite.name == "Alekss")
		AudioSource.PlayClipAtPoint(skanas[0], transform.position);
		else
		AudioSource.PlayClipAtPoint(skanas[1], transform.position);
	}
}
