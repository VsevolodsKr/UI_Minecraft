using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzeijs : MonoBehaviour{
    public void UzSakumu(){
        SceneManager.LoadScene("StartaAina", LoadSceneMode.Single);
    }
    public void UzUI(){
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void Apturet(){
        Application.Quit();
    }
}
