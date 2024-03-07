using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn_Boss : MonoBehaviour
{

    private Boss_CTRL Boss;
    public GameObject GameObjectToSpawn;
    public Transform spawnPosition;

    public float ScalableColliderSize = 5;

    public bool playOnce;
    bool played;

    ScreenShake screenShake;

    void Start()
    {
        screenShake = FindObjectOfType<ScreenShake>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && (!playOnce || !played))
        {
            played = true;
            Boss = Instantiate(GameObjectToSpawn, spawnPosition.position, spawnPosition.rotation).GetComponent<Boss_CTRL>();
            Boss.Init(ScalableColliderSize);

            //Boss.GetComponentInChildren<Animator>().SetBool("Apparition",true);
            //GameObject.Find("Boss_Snake_Prefab").GetComponentInChildren<Animator>().SetBool("Apparition", true);

            Boss_CTRL.CurrentBoss = Boss;
            screenShake.ShakeRandom();
        }
    }

    void OnDrawGizmos()
    {
        Vector3 offset = Vector3.up * 0.5f;
        Gizmos.DrawLine(transform.position + offset, spawnPosition.position + offset);
    }
}
