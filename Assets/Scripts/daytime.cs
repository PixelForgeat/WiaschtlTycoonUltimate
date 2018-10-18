using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daytime : MonoBehaviour {
    // Update is called once per frame
    public float TurnSpeedX = 5f;
    public float TurnSpeedZ = 5f;
    void Update () {
        transform.Rotate(Time.deltaTime * TurnSpeedX, 0f, Time.deltaTime * TurnSpeedZ);
    }
}
