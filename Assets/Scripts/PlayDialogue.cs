using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayDialogue : MonoBehaviour
{
    [SerializeField] private Dialogue dialogueSO;


    [SerializeField] private TextMeshProUGUI dialogueText;

    [SerializeField] private float textDelay = 4f;



    int index = 0;

    void Start()
    {
        dialogueText.text = dialogueSO.DialogueText[index];
        InvokeRepeating("nextString", 3.0f, textDelay);
    }


    void nextString()
    {
        if (index <= dialogueSO.DialogueText.Length - 1)
        {

            dialogueText.text = dialogueSO.DialogueText[index];


            if (dialogueSO.DialogueText[index].Length > 0 && !char.IsLetter(dialogueSO.DialogueText[index][0]))
            {
                dialogueText.fontStyle = FontStyles.Normal;

            }
            else
            {

                dialogueText.fontStyle = FontStyles.Italic | FontStyles.Bold;

            }


            index++;
        }
        if (index == dialogueSO.DialogueText.Length)
        {
            CancelInvoke("nextString");

            Debug.Log("Invoke stopped");
        }
    }

}



