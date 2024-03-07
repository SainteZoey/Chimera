using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructiblePlatform : MonoBehaviour
{
    public float ExplosionForce = 10;
    public float ExplosionRadius = 10;
    public Transform explosionSource;
    public GameObject fx;

    public Transform bodiesParent;

    public AudioSource Kaboum;

    void Start()
    {
        if(bodiesParent == null)
        {
            bodiesParent = transform;
        }
    }

    public void PlayExplosion()
    {
        Destroy(explosionSource.position);
        Kaboum.Play();
        Instantiate(fx, transform.position, Quaternion.identity);
    }

    public void Destroy(Vector3 positionExplosion)
    {
        Rigidbody[] Bodies = bodiesParent.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody b in Bodies)
        {
            b.isKinematic = false;
            b.useGravity = true;
            b.AddExplosionForce(ExplosionForce, positionExplosion, ExplosionRadius);
        }
    }

    
}
