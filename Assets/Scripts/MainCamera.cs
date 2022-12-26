using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public static float MinY { get; private set; }
    public static float MaxY { get; private set; }

    public float minY, maxY;

    void Start()
    {
        MinY = minY;
        MaxY = maxY;
    }
}
