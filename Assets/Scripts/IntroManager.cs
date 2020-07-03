using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
            
    }


    public void touchBtnAdopt()
    {
        Debug.Log("버튼이 눌렸다!");
        Debug.Log("고양이를 만나자!");
        SceneManager.LoadScene("Meet");
    }

    public void touchBtnSetting()
    {
        Debug.Log("환경설정으로 간다.");
    }
}
