using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] foostepsOnGrass;
    public AudioClip[] foostepsOnStone;
    public AudioClip[] foostepsOnWood;

    public string material;

    void PlayFootstepSound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = Random.Range(0.9f, 1.0f);
        audioSource.pitch = Random.Range(0.9f, 1.1f);

        switch (material)
        {
            case "Grass":
                if (foostepsOnGrass.Length > 0)
                    audioSource.PlayOneShot(foostepsOnGrass[Random.Range(0, foostepsOnGrass.Length)]);
                break;

            case "Stone":
                if (foostepsOnStone.Length > 0)
                    audioSource.PlayOneShot(foostepsOnStone[Random.Range(0, foostepsOnStone.Length)]);
                break;

            case "Wood":
                if (foostepsOnWood.Length > 0)
                    audioSource.PlayOneShot(foostepsOnWood[Random.Range(0, foostepsOnWood.Length)]);
                break;

            default:
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Grass":
            case "Stone":
            case "Wood":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
}
