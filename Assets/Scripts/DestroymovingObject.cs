using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroymovingObject : MonoBehaviour
{
    bool aremoving;

    void LateUpdate()
    {
        GameObject[] Rocks = GameObject.FindGameObjectsWithTag("Rock");
        foreach (GameObject Rock in Rocks)
        {
            if (Rock.GetComponent<Rigidbody>() == null)
            {
                continue;
            }
            if (Rock.GetComponent<Rigidbody>().velocity.magnitude > 0.01)
            {
                aremoving = true;
            }
            if (Rock.GetComponent<Rigidbody>().velocity.magnitude <= 0.01)
            {
                aremoving = false;
            }
        }
        Debug.Log("Rocks moving: " + aremoving);
    }
}
