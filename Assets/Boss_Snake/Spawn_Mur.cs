using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Mur : MonoBehaviour
{

    private GameObject Boss;
    public GameObject GameObjectToSpawn;
    public Transform spawnPosition;

    public Transform target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Boss = Instantiate(GameObjectToSpawn, spawnPosition.position, spawnPosition.rotation);
            
        }
    }

    void OnDrawGizmos()
    {
        Vector3 offset = Vector3.up * 0.5f;
        Gizmos.DrawLine(transform.position + offset, spawnPosition.position + offset);
    }
}