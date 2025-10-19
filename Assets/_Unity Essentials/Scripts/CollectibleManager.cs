using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;
    public int totalCollectibles;
    public GameObject celebrationEffect;
    private bool hasCelebrated = false;

    private void Awake()
    {
        Instance = this;
    }

    public void Collect()
    {
        totalCollectibles--;

        if (totalCollectibles <= 0 && !hasCelebrated)
        {
            Instantiate(celebrationEffect, Vector3.zero, Quaternion.identity);
            hasCelebrated = true;
        }
    }
}
