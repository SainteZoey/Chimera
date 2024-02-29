using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Mur : MonoBehaviour
{

    private Boss_CTRL Boss;
    public GameObject GameObjectToSpawn;
    public Transform spawnPosition;
    GameObject Bossdisactived;


    bool HasPlayed;

    void Update()
    {


        if (HasPlayed == true)
        {
            Bossdisactived.SetActive(false);
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (HasPlayed == false)
        {
            if (other.gameObject.tag == "Player")
            {
                HasPlayed = true;
                Instantiate(GameObjectToSpawn, spawnPosition.position, transform.rotation);
                //Boss_CTRL.CurrentBoss.enabled = false;
                //Bossdisactived = Boss_CTRL.CurrentBoss.gameObject;
            }
        }
    }

    void OnDrawGizmos()
    {
        Vector3 offset = Vector3.up * 0.5f;
        Gizmos.DrawLine(transform.position + offset, spawnPosition.position + offset);
    }
}