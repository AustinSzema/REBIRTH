using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayDialogue : MonoBehaviour
{
    [SerializeField] private Dialogue dialogueSO;


    [SerializeField] private TextMeshProUGUI dialogueText;

    int index = 0;

    void Start()
    {
        dialogueText.text = dialogueSO.DialogueText[index];
        InvokeRepeating("nextString", 3.0f, 6f);
    }


    void nextString()
    {
        if(index <= dialogueSO.DialogueText.Length - 1)
        {
            dialogueText.text = dialogueSO.DialogueText[index];
            index++;

        }
    }

}
