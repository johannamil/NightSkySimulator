using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public GameObject starPrefab;
    public StarData star;

    public void GenerateStars(Vector3 coords, StarData star)
    {
        GameObject newstar = Instantiate(starPrefab, coords, Quaternion.identity);

DisplayData data = newstar.GetComponent<DisplayData>();
data.starData = star;
    }

}