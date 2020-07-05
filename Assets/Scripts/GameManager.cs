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

    public string catName;
    public string catSex;
    
    
    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("name"));
        Debug.Log(PlayerPrefs.GetString("sex"));
        Debug.Log(PlayerPrefs.GetString("breed"));
    }
}
