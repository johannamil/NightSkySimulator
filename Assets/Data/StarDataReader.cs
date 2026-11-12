using System.Collections.Generic;
using UnityEngine;

public class StarDataReader : MonoBehaviour
{

    public List<StarData> stars = new List<StarData>();
    //makes a new list struct for my data
      public bool dataLoaded = false;


    public void ReadStarData(string datafile)
    {
        Debug.Log("ReadStarData was called");
        string[] lines = datafile.Split('\n');
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
            //new star object - at the minute I'm only querying for name, RA, dec
            star.name = values[0].Trim().Trim('"');
            star.rightAscension = float.Parse(values[1]);
            star.declination = float.Parse(values[2]);
            //star fields
            stars.Add(star);
            Debug.Log("Added star: " + star.name);
        }
        Debug.Log("Loaded " + stars.Count + " stars.");
        dataLoaded = true;
        //writes it to the console
    }
}