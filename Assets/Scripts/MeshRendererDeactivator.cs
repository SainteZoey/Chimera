using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererDeactivator : MonoBehaviour
{
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
