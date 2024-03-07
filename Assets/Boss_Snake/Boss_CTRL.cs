using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss_CTRL : MonoBehaviour
{
    public float SpawnTiming;
    public Rigidbody Rb;
    public float Speed;
    public static Boss_CTRL CurrentBoss;

    public Transform scalableCollider;


    void FixedUpdate()
    {
        
        if (SpawnTiming > 0.0f)
        {
            SpawnTiming -= Time.fixedDeltaTime;
            if (SpawnTiming <= 0.0f)
            {
                
                gameObject.GetComponentInChildren<Animator>().SetFloat("Walk", 1.1f);
            }
        }
        else
        {
            Rb.MovePosition(Rb.transform.position + Rb.transform.forward * Speed * Time.fixedDeltaTime);
        }
    }

    public void Init(float scalableColliderSize)
    {
        scalableCollider.localScale = new Vector3(scalableColliderSize, scalableCollider.localScale.y, scalableCollider.localScale.z);
    }



    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.TryGetComponent<DestructiblePlatform>(out var destructiblePlatform))
        {
            destructiblePlatform.PlayExplosion();
        }
        if (other.gameObject.tag == "Death")
        {
            
            gameObject.GetComponentInChildren<Animator>().SetBool("Death", true);
            this.enabled = false;
        }
    }
}
