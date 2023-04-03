using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class PlayVoice : MonoBehaviour
{
    [SerializeField] private Voice voiceSO;
    [SerializeField] private UnityEvent voice_Transition;
    [SerializeField] private float voiceDelay = 6f;
    [SerializeField] private bool isVoiceTransitionScene;
    int voiceIndex = 0;



    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(voiceSO.VoiceActing[voiceIndex], transform.position);
        InvokeRepeating("nextAudioClip", 7.0f, voiceDelay);
    }

    void nextAudioClip()
    {
        if (voiceIndex <= voiceSO.VoiceActing.Length - 1)
        {
            voiceIndex++;
            AudioSource.PlayClipAtPoint(voiceSO.VoiceActing[voiceIndex], transform.position);
           
        }
    }

}
