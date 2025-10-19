using UnityEngine;

public class DayCycle : MonoBehaviour
{
    // How many real-world seconds one full day lasts
    public float dayDuration = 120f;

    void Update()
    {
        // Calculate how much to rotate this frame
        float rotationPerSecond = 360f / dayDuration;

        // Rotate the light around the X axis over time
        transform.Rotate(Vector3.right * rotationPerSecond * Time.deltaTime);
    }
}