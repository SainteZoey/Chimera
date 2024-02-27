using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Victory_script : MonoBehaviour
{
    public Object sceneToLoad;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneToLoad.name);
    }
}
