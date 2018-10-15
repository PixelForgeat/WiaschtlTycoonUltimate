using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour {
    public static float Money = 0f;
    public static List<Product> products;
}

public class Product
{
    public string Name;
    public int duration;
}
