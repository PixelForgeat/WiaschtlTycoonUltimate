using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour {
    public static double Money = 0f;
    public static List<Product> products;
}

public class Product
{
    public Product( string sName , int iDuration )
    {
        m_sName = sName;
        m_iDuration = iDuration;
    }
    public string m_sName;
    public int m_iDuration;
}
