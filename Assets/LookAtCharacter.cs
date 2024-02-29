using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCharacter : MonoBehaviour
{
    GameObject Character;

    private void Start()
    {
        Character = FindObjectOfType<Character>().gameObject;
    }

    void Update()
    {
        gameObject.transform.LookAt(Character.transform);
    }
}
