using UnityEngine;

public class CoordConvert : MonoBehaviour
{
    public float radius = 20f;
    public Vector3 Coordinates(float RA, float dec)
    {
        float radianRA = RA * Mathf.Deg2Rad;
        float radiandec = dec * Mathf.Deg2Rad;
        float x = radius * Mathf.Cos(radianRA) * Mathf.Cos(radiandec);
        float y = radius * Mathf.Sin(radiandec);
        float z = radius * Mathf.Cos(radiandec) * Mathf.Sin(radianRA);
        Vector3 coords = new Vector3(x, y, z);
        return coords;
    }
}
