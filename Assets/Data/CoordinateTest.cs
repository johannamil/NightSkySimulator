using UnityEngine;

public class CoordinateTest : MonoBehaviour
{
    public CoordConvert converter;
    void Start()
    {
   
        float RA = 101.2875f;
        float dec = -16.7161f;

        Vector3 coords = converter.Coordinates(RA, dec);
        Debug.Log(coords);

    }
}
