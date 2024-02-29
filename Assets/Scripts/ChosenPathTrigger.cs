using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChosenPathTrigger : MonoBehaviour
{
    public TemporarySaveData saveData;
    public int chosenPath;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            saveData.ChosenPath = chosenPath;
        }
    }
}
