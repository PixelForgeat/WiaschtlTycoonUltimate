using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour {
    public Text MoneyText;
    
	void Update ()
    {
	}
    private void LateUpdate()
    {
        updateMoney();
    }

    public void MoneyPlusHundret()
    {
        Storage.Money += Random.Range(1f, 100f);
        print(Storage.Money);
    }

    void updateMoney() => MoneyText.text = (((int)+((Storage.Money - ((int)Storage.Money)) * 100)) >= 10) ? "Money " + ((int)Storage.Money).ToString() + "," + ((int)((Storage.Money - ((int)Storage.Money)) * 100)).ToString() : "Money " + ((int)Storage.Money).ToString() + "," + "0" + ((int)((Storage.Money - ((int)Storage.Money)) * 100));
}
