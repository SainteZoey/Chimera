using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveSceneLoader : MonoBehaviour
{
    public string[] additiveScenesNames;
    void Start()
    {
#if !UNITY_EDITOR
        foreach (var additiveScene in additiveScenesNames)
        {
            SceneManager.LoadScene(additiveScene, LoadSceneMode.Additive);
        }
#endif
    }

}
