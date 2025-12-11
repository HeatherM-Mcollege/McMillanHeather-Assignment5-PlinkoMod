using UnityEngine;
using UnityEngine.Audio;

public class PegCollisionSound : MonoBehaviour
{
    //make audio sound variable 
    public AudioClip discCollisionSound;
    //make refereence for audio
    private AudioSource audioSource;


    private void Start()
    {
        //tie audio tied to game object
        audioSource = GetComponent<AudioSource>();

    }

    //create collision check of gameobject
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check for source and play audio once
        if (audioSource != null && discCollisionSound != null)
        {
            audioSource.PlayOneShot(discCollisionSound);
        }
    }
}
