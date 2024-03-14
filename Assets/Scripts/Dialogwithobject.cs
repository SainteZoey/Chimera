using JetBrains.Annotations;
using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class Dialogwithobject : MonoBehaviour
{
    public GameObject DialogRoot;
    public TextMeshProUGUI characterDialogText;
    public GameObject TextInteraction;
    
    public Image characterAvatarImage;

    public Sprite playerCharacterAvatarSprite;
    public Sprite otherCharacterAvatarSprite;

    public DialogInfo[] DialogInfos;

    int sentenceIndex;

    float startSentenceDelay = 0.50f;
    float sentenceDelay = 0.1f;

    float currentSentenceDelay;

    bool playedOnce;
    public bool IsPlaying;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TextInteraction.SetActive(true);

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    DialogRoot.gameObject.SetActive(true);
                    TextInteraction.SetActive(false);
                    PlayNextSentence();
                    Debug.Log("Tu as appuyé sur espace pour lancer le dialogue.");
                }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        TextInteraction.SetActive(false);
    }


    void PlayNextSentence()
    {
        //Debug.Log("Next sentence!");
        // si l'index ne d�passe pas la taille du tableau
        if (sentenceIndex < DialogInfos.Length)
        {
            // assigner le la phrase en cours au characterDialogText
            characterDialogText.text = DialogInfos[sentenceIndex].dialogText;

            if (DialogInfos[sentenceIndex].isOtherCharacter)
            {
                // assigner l'avatar de l'autre personnage � l'image
                characterAvatarImage.sprite = otherCharacterAvatarSprite;
            }
            else
            {
                // assigner l'avatar du personnage-jouer � l'image
                characterAvatarImage.sprite = playerCharacterAvatarSprite;
            }
            sentenceIndex++;
        }
        else
        {
            // end dialog
            DialogRoot.gameObject.SetActive(false);
        }
    }

    [Serializable]
    public struct DialogInfo
    {
        public string dialogText;
        public bool isOtherCharacter;
    }
}
