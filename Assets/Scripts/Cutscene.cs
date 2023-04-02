using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene : MonoBehaviour
{
    [SerializeField] Sprite[] frames;
    [SerializeField] private float[] delayAfterFrame;
    //[SerializeField] private float delayBetweenFrames;
    [SerializeField] Image screen;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayCutscene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator PlayCutscene()
    {
        for (int count = 0; count < frames.Length; count += 1)
        {
            screen.sprite = frames[count];
            yield return new WaitForSeconds(delayAfterFrame[count]);
        }
    }

}
