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

    void FixedUpdate()
    {
        if (SpawnTiming > 0.0f)
        {
            SpawnTiming -= Time.fixedDeltaTime;
            if (SpawnTiming <= 0.0f)
            {
                gameObject.GetComponent<Animator>(); // rampe
            }
        }
        else
        {
            Rb.MovePosition(Rb.transform.position + Rb.transform.forward * Speed * Time.fixedDeltaTime);
        }
    }
}
