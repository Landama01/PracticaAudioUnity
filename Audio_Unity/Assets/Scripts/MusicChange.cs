using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicChange : MonoBehaviour
{
    public AudioMixerSnapshot IndoorSnapshot;
    public AudioMixerSnapshot OutdoorSnapshot;

    public float transitionTime = 0.2f;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Indoor")
            IndoorSnapshot.TransitionTo(transitionTime);
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag != "Indoor")
            OutdoorSnapshot.TransitionTo(transitionTime);
    }
}
