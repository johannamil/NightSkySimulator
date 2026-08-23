using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public GameObject starPrefab;
    public int starCount = 100;
    public float radius = 20f;

    void Start()
    {
        for (int i = 0; i < starCount; i++)
        {
            Vector3 pos = Random.onUnitSphere * radius;

            if (pos.y > 0)
            {
                Instantiate(starPrefab, pos, Quaternion.identity);
            }
        }
    }
}