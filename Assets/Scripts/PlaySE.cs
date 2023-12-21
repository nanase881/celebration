using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    [SerializeField] AudioClip se;
    AudioSource audioSource;
    //bool isAudioStart = false;
    // Start is called before the first frame update
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(se);
        Invoke("DestroyItself", 3f);
        ;
    }

    void DestroyItself()
    {
        Destroy(gameObject);
    }
}
