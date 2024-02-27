using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eboulement_trigger : MonoBehaviour
{

    public DestructiblePlatform destructiblePlatform;

    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            destructiblePlatform.PlayExplosion();
            Boss_CTRL.CurrentBoss.enabled = false;
            
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