﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daytime : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.right, Time.deltaTime * 10f);
	}
}
