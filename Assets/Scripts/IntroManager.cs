using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    public Button btnAdopt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }


    public void btnTest()
    {
        Debug.Log("버튼이 눌렸다!");
        Debug.Log("메인으로 가자!");
        SceneManager.LoadScene("Main");
    }
}
