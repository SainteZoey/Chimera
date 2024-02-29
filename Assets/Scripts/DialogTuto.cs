using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DialogTuto : MonoBehaviour
{
    public bool IsPlaying;
    public GameObject DialogRoot;
    public TextMeshProUGUI characterNameText;
    public TextMeshProUGUI characterDialogText;
    public Image characterAvatarImage;
    // Start is called before the first frame update
    void Start()
    {
        IsPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
