using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScreen : MonoBehaviour
{

    [SerializeField] private Image screenFade;

    private float alpha = 0f;

    [SerializeField] private float fadeSpeed = 0.1f;

    public bool fadeToBlack = false;

    [SerializeField] private PlayDialogue playDialogue;

    private Color black = new Color(0f, 0f, 0f, 100f);

    // Update is called once per frame
    void Update()
    {
        if(fadeToBlack == true && screenFade.color.a != 100f)
        {
            screenFade.color = new Color(0f, 0f, 0f, alpha);
            alpha += fadeSpeed * Time.deltaTime;
        }
        if(screenFade.color == black)
        {

        }

        if(fadeToBlack == false && screenFade.color.a != 0f)
        {
            screenFade.color = new Color(0f, 0f, 0f, alpha);
            alpha -= fadeSpeed * Time.deltaTime;
        }



    }
}
