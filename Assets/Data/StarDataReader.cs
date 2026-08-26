using System.Collections.Generic;
using UnityEngine;

public class StarDataReader : MonoBehaviour
{
    public TextAsset starCSV;

    public List<StarData> stars = new List<StarData>();

    void Start()
    {
        ReadCSV();
    }

    void ReadCSV()
    {
        string[] lines = starCSV.text.Split('\n');

        // Start at 1 because line 0 contains the column headings
        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i]))
                continue;

            string[] values = lines[i].Split(',');

            StarData star = new StarData();

            star.name = values[0];
            star.rightAscension = float.Parse(values[1]);
            star.declination = float.Parse(values[2]);
            star.magnitude = float.Parse(values[3]);
            star.constellation = values[4];
            star.spectralType = values[5];

            stars.Add(star);
        }

        Debug.Log("Loaded " + stars.Count + " stars.");
    }
}