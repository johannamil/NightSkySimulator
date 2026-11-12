using UnityEngine;
using System.Collections;

public class StarGeneratorCallMethod : MonoBehaviour
{
    public StarGenerator starGenerator;
    public CoordConvert coordConvert;
    public StarDataReader starDataReader;
    IEnumerator Start()
    {
        yield return new WaitUntil(() => starDataReader.dataLoaded);
        Generate();
    }
    //waits until the data has loaded from the reader method

    public void Generate()
    {
        foreach (StarData star in starDataReader.stars)
        {
            Vector3 coords = coordConvert.Coordinates(star.rightAscension, star.declination);
            starGenerator.GenerateStars(coords, star);
        }
    }
}
