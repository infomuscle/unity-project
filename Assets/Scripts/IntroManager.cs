using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("Game Start!");
    }

    public void toucnBtnStart()
    {
        Debug.Log("Go Adopt!");
        SceneManager.LoadScene("Adopt");
    }
}
