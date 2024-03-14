using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        Text.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
    }
}
