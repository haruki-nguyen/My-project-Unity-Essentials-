using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    // Holds a reference to the Animator that controls the door
    private Animator doorAnimator;

    void Start()
    {
        // Find and store the Animator component attached to this door
        doorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // When something enters the trigger area...
        if (other.CompareTag("Player")) // ...check if it’s the player
        {
            if (doorAnimator != null)
            {
                // Play the door opening animation
                doorAnimator.SetTrigger("Door_Open");
            }
        }
    }
}