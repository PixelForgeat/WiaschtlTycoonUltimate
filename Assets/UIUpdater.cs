using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIUpdater : MonoBehaviour {

    public Text MoneyText;

    void Update ()
    {
        Storage.Money += Random.Range(.1f, 19999999f);
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

    void updateMoney() => MoneyText.text = (((long)+((Storage.Money - ((long)Storage.Money)) * 100)) >= 10) ? "Money " + ((long)Storage.Money).ToString() + "," + ((long)((Storage.Money - ((long)Storage.Money)) * 100)).ToString()+ " DEM" : "Money " + ((long)Storage.Money).ToString() + "," + "0" + ((long)((Storage.Money - ((long)Storage.Money)) * 100))+ " DEM";
}
