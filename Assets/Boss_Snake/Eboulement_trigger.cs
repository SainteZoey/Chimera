using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eboulement_trigger : MonoBehaviour
{

    public DestructiblePlatform destructiblePlatform;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            destructiblePlatform.PlayExplosion();
        }
    }

    void OnDrawGizmos()
    {
        if (destructiblePlatform != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, destructiblePlatform.transform.position);
        }

    }
}