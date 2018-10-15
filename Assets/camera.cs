using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public Camera mainCam;
    public float scaler = 1f;

	// Update is called once per frame
	void Update () {
        float x = mainCam.transform.position.x;
        x -= ( Input.GetAxis("Horizontal") * scaler);
        if(x > 15)
        {
            x = 15;
        }
        if( x < -45)
        {
            x = -45;
        }
        mainCam.transform.position = new Vector3(x, mainCam.transform.position.y, mainCam.transform.position.z);
	}
}
