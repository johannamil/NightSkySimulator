using System.Collections.Generic;
using UnityEngine;

public class StarDataReader : MonoBehaviour
{
    public TextAsset starCSV;
    public List<StarData> stars = new List<StarData>();
    //makes a new list struct for my StarData
    void Start()
    {
        ReadStarData();
    }
    void ReadStarData()
    {
        string[] lines = starCSV.text.Split('\n');
        //creates array of values from CSV text
        //splits the text when there is a new line so you only get 1 star per array
        // start at 1 because 0 isn't star data
        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i]))
                continue;
            //so the program doesn't count spaces
            string[] values = lines[i].Split(',');
            //splits the values at the comma
            StarData star = new StarData();
            //new star object
            star.name = values[0];
            star.rightAscension = float.Parse(values[1]);
            star.declination = float.Parse(values[2]);
            star.magnitude = float.Parse(values[3]);
            star.constellation = values[4];
            star.spectralType = values[5];
            //star fields
            stars.Add(star);
        }
        Debug.Log("Loaded " + stars.Count + " stars.");
        //writes it to the console
    }
}