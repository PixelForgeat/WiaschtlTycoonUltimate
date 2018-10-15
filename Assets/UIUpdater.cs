using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour {
    public Text MoneyText;
    
	void Update ()
    {
        updateMoney();
	}

    void updateMoney() => MoneyText.text = "Money " + Storage.Money.ToString();
}
