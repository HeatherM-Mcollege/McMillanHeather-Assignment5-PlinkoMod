using UnityEngine;

public class scoreSound : MonoBehaviour
{
    //make audio sound variable 
    public AudioClip scoreAudio;
    //make refereence for audio
    private AudioSource audioSource;


    private void Start()
    {
        //tie source audio to game object
        audioSource = GetComponent<AudioSource>();

    }

    //create collision check of gameobject
    private void OnTriggerEnter2D(Collider2D other)
    {
        //check for source and play audio once
        if (audioSource != null && scoreAudio != null)
        {
            audioSource.PlayOneShot(scoreAudio);
        }
    }
 
}
