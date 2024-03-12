using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroymovingobject : MonoBehaviour
{
    bool aremoving;
    public float randomNumber;

    private void Start()
    {
         randomNumber = Random.Range(0.0f, 2.0f);
    }

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
            if (aremoving == true)
            {
                if(randomNumber >= 1.0f)
                {
                    Destroy(Rock);
                }
            }
        }
        
    }
}
