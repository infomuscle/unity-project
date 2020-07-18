using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour {
    void Start() {
        Debug.Log("Game Start!");
    }
    
    public void toucnBtnStart() {
        // if (PlayerPrefs.GetString("name") == null) {
            Debug.Log("Go Adopt!");
            SceneManager.LoadScene("Adopt");
        // } else {
            // SceneManager.LoadScene("Main");
        // }
    }
}