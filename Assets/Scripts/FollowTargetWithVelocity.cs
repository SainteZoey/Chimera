using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetWithVelocity : MonoBehaviour
{
    public Transform target;
    public Rigidbody rb;
    public float speed;

    Vector3 velocity;

     void FixedUpdate()
    {
        rb.velocity = Vector3.SmoothDamp(Vector3.zero, (target.position - rb.position) * speed, ref velocity, 0.1f);
    }
}
