using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eboulement_trigger : MonoBehaviour
{

    public DestructiblePlatform destructiblePlatform;
    bool HasPlayed;
    public float desactivateBossDelay;
    GameObject bossdisactived;
    public Boss_CTRL Boss;

    public float timerDesactivateBoss;


    ScreenShake screenShake;

    void Start()
    {
        screenShake = FindObjectOfType<ScreenShake>();
        timerDesactivateBoss = 0.0f;
    }

    void Update()
    {
        if (HasPlayed == true)
        {
            desactivateBossDelay -= Time.deltaTime;
            if (desactivateBossDelay <= 0.0f)
            {
                bossdisactived.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (HasPlayed == false)
        {

            if (other.gameObject.tag == "Player")
            {
                HasPlayed = true;
                destructiblePlatform.PlayExplosion();

                Boss_CTRL.CurrentBoss.gameObject.GetComponentInChildren<Animator>().SetBool("Idle", true);

                bossdisactived = Boss_CTRL.CurrentBoss.gameObject;
                Boss_CTRL.CurrentBoss.enabled = false;

                screenShake.ShakeRandom();
            }
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