using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Rotate(Vector3.forward, 180 * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            audioSource.PlayOneShot(audioSource.clip);
            Destroy(gameObject);
        }
    }
}
