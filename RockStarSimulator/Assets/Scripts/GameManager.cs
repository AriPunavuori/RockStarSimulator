using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
    public TextMeshProUGUI uiText;
   public float totalCost = 0;
    public float textTimer;
    public float textTime = 5;

    void Start() {
        textTimer = textTime;
        UpdateUI("" + totalCost);
    }


    private void Update() {
        if (textTimer < 0)
            UpdateUI("");
        textTimer -= Time.deltaTime;
    }


    void UpdateUI(string s) {
        if (s != "")
            uiText.text = "So far you have trashed " + s + "$ worht of shit!";
        else
            uiText.text = "";
        textTimer = textTime;
    }

    public void ObjectTrashed(float v) {
        totalCost += v;
        UpdateUI("" + totalCost);
    }

}
