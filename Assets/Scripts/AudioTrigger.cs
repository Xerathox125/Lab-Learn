using UnityEngine;

public class AudioTrigger : MonoBehaviour
{

    private AudioSource AudioSource;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.Play();
            other.transform.localScale += Vector3.one * 0.5f;

            other.gameObject.GetComponent<PlayerMovement>().MaxGroundedDistance += 0.5f;

        }
    }


}
