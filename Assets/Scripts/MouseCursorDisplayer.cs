using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorDisplayer : MonoBehaviour
{
    public bool lockAtStart;
    void Start()
    {
			Cursor.lockState = lockAtStart ? CursorLockMode.Locked : CursorLockMode.None;
    }
}
