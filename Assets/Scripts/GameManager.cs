using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager
    {
        get
        {
            if (m_gameManager == null)
            {
                m_gameManager = FindObjectOfType<GameManager>();
            }
            return m_gameManager;
        }
    }

    private static GameManager m_gameManager;
    
    
    
    private GameObject btnAdopt;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        btnAdopt = GameObject.Find("ButtonAdopt");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
