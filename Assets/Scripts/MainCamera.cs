using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public static float MinY { get; private set; }
    public static float MaxY { get; private set; }
    public static float MinX { get; private set; }
    public static float MaxX { get; private set; }

    public float minY, maxY, minX, maxX;

    void Start()
    {
        MinY = minY;
        MaxY = maxY;

        MinX = minX;
        MaxX = maxX;
    }
}
