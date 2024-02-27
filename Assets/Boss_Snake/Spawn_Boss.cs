using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn_Boss : MonoBehaviour
{

    private Boss_CTRL Boss;
    public GameObject GameObjectToSpawn;
    public Transform spawnPosition;

    public bool playOnce;
    bool played;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !playOnce || !played)
        {
            played = true;
            Boss = Instantiate(GameObjectToSpawn, spawnPosition.position, spawnPosition.rotation).GetComponent<Boss_CTRL>();
            Boss.GetComponentInChildren<Animator>().SetBool("Apparition",true);
            Boss_CTRL.CurrentBoss = Boss;
        }
    }

    void OnDrawGizmos()
    {
        Vector3 offset = Vector3.up * 0.5f;
        Gizmos.DrawLine(transform.position + offset, spawnPosition.position + offset);
    }
}
