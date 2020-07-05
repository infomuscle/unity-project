using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdoptManager : MonoBehaviour
{
    public String sex;
    public String breed;
    public String name;
    
    // 성별 선택 버튼
    public Button buttonMale;
    public Button buttonFemale;

    // 품종 선택 버튼
    public Button buttonMackerel;
    public Button buttonCheese;
    public Button buttonTricolor;

    public GameObject cat;
    public InputField inputFieldName;
    public Text textSex;
    public Text textBreed;

    public bool isSexselected = false;
    public bool isBreedselected = false;
    public bool isNameselected = false;
    
    
    // 결정 버튼
    public Button buttonSelect;

    private void OnEnable()
    {
        Debug.Log("Adopt OnEnable!");
    }
    
    void Start()
    {

        Debug.Log("Adopt Start!");
        
        buttonMale = GameObject.Find("Canvas").transform.Find("ButtonMale").GetComponent<Button>();
        buttonFemale = GameObject.Find("Canvas").transform.Find("ButtonFemale").GetComponent<Button>();
        buttonMale.gameObject.SetActive(true);
        buttonFemale.gameObject.SetActive(true);
        
        buttonMackerel = GameObject.Find("Canvas").transform.Find("ButtonMackerel").GetComponent<Button>();
        buttonCheese = GameObject.Find("Canvas").transform.Find("ButtonCheese").GetComponent<Button>();
        buttonTricolor = GameObject.Find("Canvas").transform.Find("ButtonTricolor").GetComponent<Button>();

        cat = GameObject.Find("Canvas").transform.Find("Cat").gameObject;
        textSex = GameObject.Find("Canvas").transform.Find("TextSex").GetComponent<Text>();
        textBreed = GameObject.Find("Canvas").transform.Find("TextBreed").GetComponent<Text>();
        inputFieldName = GameObject.Find("Canvas").transform.Find("InputFieldName").GetComponent<InputField>();
        
        buttonSelect = GameObject.Find("Canvas").transform.Find("ButtonSelect").GetComponent<Button>();
    }

    public void TouchButtonSex(String sex)
    {
        // 선택된 이미지로 변경

        // 선택된 성별 값 가져오기
        this.sex = sex;
        
        // 결정 버튼 활성화
        buttonSelect.gameObject.SetActive(true);
    }

    public void TouchButtonBreed(String breed)
    {
        // 선택된 이미지로 변경
        
        // 선택된 품종 값 가져오기
        this.breed = breed;
        
        // 결정 버튼 활성화
        buttonSelect.gameObject.SetActive(true);
    }

    public void TouchButtonSelect()
    {
        
        if (isSexselected == false && !String.IsNullOrEmpty(sex))
        {
            SelectSex();
        }
        else if (isBreedselected == false && !String.IsNullOrEmpty(breed))
        {
            SelectBreed();
        }
        else if (isNameselected == false)
        {
            SelectName();
        }
    }

    public void SelectSex()
    {
        isSexselected = true;
        
        buttonMale.gameObject.SetActive(false);
        buttonFemale.gameObject.SetActive(false);
        
        buttonSelect.gameObject.SetActive(false);
        
        buttonMackerel.gameObject.SetActive(true);
        buttonCheese.gameObject.SetActive(true);
        buttonTricolor.gameObject.SetActive(true);
    }

    public void SelectBreed()
    {
        isBreedselected = true;
        
        buttonMackerel.gameObject.SetActive(false);
        buttonCheese.gameObject.SetActive(false);
        buttonTricolor.gameObject.SetActive(false); 
        
        textSex.text += sex;
        textBreed.text += breed;
        
        cat.SetActive(true);
        textSex.gameObject.SetActive(true);
        textBreed.gameObject.SetActive(true);
        inputFieldName.gameObject.SetActive(true);
        
    }

    public void SelectName()
    {
        if (!String.IsNullOrEmpty(inputFieldName.text))
        {
            name = inputFieldName.text;
            PlayerPrefs.SetString("name", name);
            PlayerPrefs.SetString("breed", breed);
            PlayerPrefs.SetString("sex", sex);
            SceneManager.LoadScene("Main");
        }
        else
        {
            Debug.Log("Name Empty");
        }
    }
}
