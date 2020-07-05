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
    public void touchBtnAdopt()
    {
        Debug.Log("고양이를 만나자!");
        // SceneManager.LoadScene("Meet");
    }

    public void touchBtnSetting()
    {
        Debug.Log("환경설정으로 간다.");
    }
}
