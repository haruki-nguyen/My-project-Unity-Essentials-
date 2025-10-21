using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    // Effect prefab to spawn when this item is collected (e.g., particles or sound).
    public GameObject onCollectEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Spawn a temporary audio player so the sound won't be affect by the Destroy()
            AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, transform.position);

            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);

            // Destroy the collectible
            Destroy(gameObject);
        }
    }
}
