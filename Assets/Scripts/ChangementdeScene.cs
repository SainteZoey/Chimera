using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangementdeScene : MonoBehaviour
{
    public Button button_return;

    public string sceneToLoadName;

    void Start()
    {
        button_return.onClick.AddListener(action_button_retour);
    }

    void action_button_retour()
    {
        Debug.Log("clic sur bouton");
        SceneManager.LoadScene(sceneToLoadName);
    }
}
