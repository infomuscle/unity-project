using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdoptManager : MonoBehaviour {
    // 고양이 기본 정보
    public String sex;
    public String breed;
    public String name;

    // 성별 선택 버튼
    private List<Button> sexButtons;
    private string[] sexButtonNames = {"ButtonMale", "ButtonFemale"};

    // 품종 선택 버튼
    private List<Button> breedButtons;
    private string[] breedButtonNames = {"ButtonMackerel", "ButtonCheese", "ButtonTricolor"};

    // 결정 버튼
    private Button buttonSelect;

    public GameObject cat;
    private InputField inputFieldName;
    private Text textSex;
    private Text textBreed;

    private bool isSexSelected = false;
    private bool isBreedSelected = false;
    private bool isNameSelected = false;

    private void Awake() {
        sexButtons = new List<Button>();
        breedButtons = new List<Button>();
    }

    private void OnEnable() {
        Debug.Log("Adopt OnEnable!");

        Transform canvasTransform = GameObject.Find("Canvas").transform;

        // 성별 선택 버튼 생성
        for (int i = 0; i < sexButtonNames.Length; i++) {
            sexButtons.Add(canvasTransform.Find(sexButtonNames[i]).GetComponent<Button>());
        }

        // 품종 선택 버튼 생성
        for (int i = 0; i < breedButtonNames.Length; i++) {
            breedButtons.Add(canvasTransform.Find(breedButtonNames[i]).GetComponent<Button>());
        }

        cat = canvasTransform.Find("Cat").gameObject;
        textSex = canvasTransform.Find("TextSex").GetComponent<Text>();
        textBreed = canvasTransform.Find("TextBreed").GetComponent<Text>();
        inputFieldName = canvasTransform.Find("InputFieldName").GetComponent<InputField>();

        buttonSelect = canvasTransform.Find("ButtonSelect").GetComponent<Button>();
    }

    void Start() {
        Debug.Log("Adopt Start!");

        foreach (Button sexButton in sexButtons) {
            sexButton.gameObject.SetActive(true);
        }
    }

    public void TouchButtonSex(String sex) {
        // 선택된 이미지로 변경

        // 선택된 성별 값 가져오기
        this.sex = sex;

        // 결정 버튼 활성화
        buttonSelect.gameObject.SetActive(true);
    }

    public void TouchButtonBreed(String breed) {
        // 선택된 이미지로 변경

        // 선택된 품종 값 가져오기
        this.breed = breed;

        // 결정 버튼 활성화
        buttonSelect.gameObject.SetActive(true);
    }

    public void TouchButtonSelect() {
        if (isSexSelected == false && !String.IsNullOrEmpty(sex)) {
            SelectSex();
        } else if (isBreedSelected == false && !String.IsNullOrEmpty(breed)) {
            SelectBreed();
        } else if (isNameSelected == false) {
            SelectName();
        }
    }

    public void SelectSex() {
        isSexSelected = true;

        foreach (Button sexButton in sexButtons) {
            sexButton.gameObject.SetActive(false);
        }

        buttonSelect.gameObject.SetActive(false);

        foreach (Button breedButton in breedButtons) {
            breedButton.gameObject.SetActive(true);
        }
    }

    public void SelectBreed() {
        isBreedSelected = true;
        foreach (Button breedButton in breedButtons) {
            breedButton.gameObject.SetActive(false);
        }

        textSex.text += sex;
        textBreed.text += breed;

        cat.SetActive(true);
        textSex.gameObject.SetActive(true);
        textBreed.gameObject.SetActive(true);
        inputFieldName.gameObject.SetActive(true);
    }

    public void SelectName() {
        if (!String.IsNullOrEmpty(inputFieldName.text)) {
            name = inputFieldName.text;

            PlayerPrefs.SetString("name", name);
            PlayerPrefs.SetString("breed", breed);
            PlayerPrefs.SetString("sex", sex);
            SceneManager.LoadScene("Main");
        } else {
            Debug.Log("Name Empty");
        }
    }
}