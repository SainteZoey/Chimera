using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Boss : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Instantiate("Boss_Snake");
            GameObject.Find("Boos_Snake").GetComponent<Animator>().SetBool("Apparition",true);
        }
    }
}
