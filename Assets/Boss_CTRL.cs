using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Boss_CTRL : MonoBehaviour
{
    public float SpawnTiming;
    public Rigidbody Rb;
    public float Speed;

    void FixedUpdate()
    {
        if (SpawnTiming > 0.0f)
        {
            SpawnTiming -= Time.fixedDeltaTime;
            if (SpawnTiming <= 0.0f)
            {
                //anim rampe

            }
        }
        else
        {
            Rb.MovePosition(Rb.transform.position +  Rb.transform.forward * Speed * Time.fixedDeltaTime);
        }
    }


}
