using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererDeactivator : MonoBehaviour
{
    void Start()
    {
        foreach (var meshRenderer in GetComponentsInChildren<MeshRenderer>())
        {
            meshRenderer.enabled = false;
        }
        var renderer = GetComponent<MeshRenderer>();
        if(renderer != null)
        {
            renderer.enabled = false;
        }
    }
}
