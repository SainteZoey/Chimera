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
    


    // les trigger des différentes fins sont bug +
    // boss dead s'arète pooo +
    // le truc en dessous ( rochers qui explosent au passage du monstre) +
    // cam est chelou ( saut / obstacles ) +
    // les obstacles ne permettent pas de sauter +
    // changement de scene hs +
    // les cailloux ONT UN SOUCIS DE COLLIDER





    /*void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.Layer == "Obstacles")
       {
            DestructiblePlatform = true;
       }
   }*/
}
