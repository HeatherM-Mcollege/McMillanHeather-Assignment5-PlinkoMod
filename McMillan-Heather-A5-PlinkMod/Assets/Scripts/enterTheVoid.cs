using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class enterTheVoid : MonoBehaviour
{

    //make audio sound variable 
    public AudioClip voidSound;
    //make refereence for audio
    private AudioSource audioSource;


    private void Start()
    {
        //reference audio source on GameObject
        audioSource = GetComponent<AudioSource>();

    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (audioSource != null && voidSound != null)
        {
            audioSource.PlayOneShot(voidSound);
        }
       
        //destroy disc on void entry
        Destroy(collider.gameObject);
    }
}
