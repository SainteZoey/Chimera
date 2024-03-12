using JetBrains.Annotations;
using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
public class DialogTuto : MonoBehaviour
{
    public GameObject DialogRoot;
    public TextMeshProUGUI characterDialogText;

    public Image characterAvatarImage;

    public Sprite playerCharacterAvatarSprite;
    public Sprite otherCharacterAvatarSprite;

    public DialogInfo[] DialogInfos;

    int sentenceIndex;

    StarterAssetsInputs starterAssetsInputs;

    bool hasReleasedJump = true;

    float startSentenceDelay = 0.75f;
    float sentenceDelay = 0.2f;

    float currentSentenceDelay;

    bool playedOnce;

    // Start is called before the first frame update
    void Start()
    {
        starterAssetsInputs = FindObjectOfType<StarterAssetsInputs>();
        DialogRoot.gameObject.SetActive(true);
        Time.timeScale = 0f;
        PlayNextSentence();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSentenceDelay <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (starterAssetsInputs.jump && hasReleasedJump))
            {
                hasReleasedJump = false;
                PlayNextSentence();
            }
            else if (starterAssetsInputs.jump == false)
            {
                hasReleasedJump = true;
            }
        }
        else
        {
            currentSentenceDelay -= Time.unscaledDeltaTime;
        }
    }

    void PlayNextSentence()
    {
        //Debug.Log("Next sentence!");
        // si l'index ne d�passe pas la taille du tableau
        if (sentenceIndex < DialogInfos.Length)
        {
            if (playedOnce)
            {
                currentSentenceDelay = sentenceDelay;
            }
            else
            {
                playedOnce = true;
                currentSentenceDelay = startSentenceDelay;
            }

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
            Time.timeScale = 1f;
        }
    }

    [Serializable]
    public struct DialogInfo
    {
        public string dialogText;
        public bool isOtherCharacter;
    }
}
