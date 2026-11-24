using UnityEngine;
using System.Collections.Generic;

public class ConstellationReader : MonoBehaviour
{
    public List<ConstellationBoundary> constellations = new List<ConstellationBoundary>();
    public string constellationfile;
    public TextAsset romanfile;

    void Start()
    {
    romanfile = Resources.Load<TextAsset>("Roman_1987_constellation_boundaries");
        constellationfile = romanfile.text;
        ReadConstellations(constellationfile);
        
    }
  public void ReadConstellations(string constellationfile)
    {
        
        string[] lines = constellationfile.Split('\n');
        //same as the star data reader code
        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i]))
                continue;
            //so the program doesn't count spaces
            string[] values = lines[i].Split(',');
            Debug.Log("constellation lines: " + lines.Length);
            Debug.Log("const values: " + values.Length);
            ConstellationBoundary constellation = new ConstellationBoundary();
            constellation.raLower = float.Parse(values[0]);
            constellation.raUpper = float.Parse(values[1]);
            constellation.decConst = float.Parse(values[2]);
            constellation.nameConst = values[3];
            Debug.Log(constellation.nameConst);
        }
    }



}
