using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowManager : MonoBehaviour
{
    public TemporarySaveData temporarySaveData;

    private void Start()
    {
        temporarySaveData.ChosenPath = -1;

    }
}
