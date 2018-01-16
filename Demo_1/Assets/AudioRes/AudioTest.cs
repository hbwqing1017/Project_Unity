using UnityEngine;
using System.Collections;

public class AudioTest : MonoBehaviour {
    public AudioSource staticAudioSource;
    public AudioClip staticAudoClip;
    AudioSource audioSource;
    GameObject audioGo;
    public void BtnClick()
    {
        if (staticAudioSource == null)
        {
            if (audioSource == null)
            {
                GameObject go = Resources.Load("Prefabs_Sound/UI_button") as GameObject;
                audioGo = Instantiate(go) as GameObject;
                audioSource = audioGo.GetComponent<AudioSource>();
            }
            audioSource.Play();
        }
        else
        {
            staticAudioSource.clip = staticAudoClip;
            staticAudioSource.Play();
        }

        Debug.Log("BtnClick");
    }
}
