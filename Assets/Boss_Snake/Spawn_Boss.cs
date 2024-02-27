using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Boss : MonoBehaviour
{

    private GameObject Boss;
    public GameObject GameObjectToSpawn;
    public Transform spawnPosition;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Boss = Instantiate(GameObjectToSpawn, spawnPosition.position, spawnPosition.rotation);
            GameObject.Find("Boss_Snake").GetComponent<Animator>().SetBool("Apparition",true);
        }
    }

    void OnDrawGizmos()
    {
        Vector3 offset = Vector3.up * 0.5f;
        Gizmos.DrawLine(transform.position + offset, spawnPosition.position + offset);
    }
}
