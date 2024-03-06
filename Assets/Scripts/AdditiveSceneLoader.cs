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
<<<<<<< Updated upstream
        foreach (var additiveScene in additiveScenesNames)
=======
        foreach (var additiveScene in additiveScenes)
>>>>>>> Stashed changes
        {
            SceneManager.LoadScene(additiveScene, LoadSceneMode.Additive);
        }
#endif
    }

}
