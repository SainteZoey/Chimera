using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{

    public CinemachineImpulseSource cinemachineImpulseSource;
    public Vector3 impulseRandomSetting;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Shake();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            ShakeRandom();
        }
    }

    public void Shake()
    {
        cinemachineImpulseSource.GenerateImpulse();

    }

    public void ShakeRandom()
    {
        Vector3 impulseVelocity = new Vector3(
            UnityEngine.Random.Range(-impulseRandomSetting.x, impulseRandomSetting.x),
            UnityEngine.Random.Range(-impulseRandomSetting.y, impulseRandomSetting.y),
            UnityEngine.Random.Range(-impulseRandomSetting.z, impulseRandomSetting.z));

        cinemachineImpulseSource.GenerateImpulse(impulseVelocity);
    }
}
