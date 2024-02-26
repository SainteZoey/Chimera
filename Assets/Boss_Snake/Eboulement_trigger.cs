using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eboulement_trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("Plateform").GetComponent<DestructiblePlatform>().enabled = true;
        }
    }
}