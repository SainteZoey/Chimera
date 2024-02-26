using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Boss : MonoBehaviour
{

    private GameObject Boss;
    public GameObject GameObjectToSpawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Boss = Instantiate(GameObjectToSpawn, gameObject.transform.localPosition, Quaternion.identity);
            GameObject.Find("Boss_Snake").GetComponent<Animator>().SetBool("Apparition",true);
        }
        
    }
}
