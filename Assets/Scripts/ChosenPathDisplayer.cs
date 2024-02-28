using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChosenPathDisplayer : MonoBehaviour
{

    public TemporarySaveData temporarySaveData;

    public GameObject[] chosenPathInfos;

    void Start()
    {
        chosenPathInfos[temporarySaveData.ChosenPath].SetActive(true);

    }



}
