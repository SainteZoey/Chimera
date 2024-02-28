using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChosenPathTrigger : MonoBehaviour
{
    public TemporarySaveData saveData;
    public int chosenPath;

    public void ChoosePath()
    {
        saveData.ChosenPath = chosenPath;

    }

        

}
