using TMPro;
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

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && GameManager.instance.isGameActive)
        {
            Debug.Log("Player entered the trigger.");
            audioSource.PlayOneShot(audioSource.clip);
            
            GameManager.instance.AddScore(1);
            
            Destroy(gameObject);
        }
    }
}
