using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveSceneLoader : MonoBehaviour
{
    public Object[] additiveScenes;
    void Start()
    {
#if !UNITY_EDITOR
        foreach (var additiveScene in additiveScenes)
        {
            SceneManager.LoadScene(additiveScene.name, LoadSceneMode.Additive);
        }
#endif
    }

}
