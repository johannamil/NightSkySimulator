using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public GameObject starPrefab;
    public StarData star;
    // this is gonna give us the data values for each individual star

    public void GenerateStars(Vector3 coords, StarData star)
    {
        GameObject newstar = Instantiate(starPrefab, coords, Quaternion.identity);
        DisplayData data = newstar.GetComponent<DisplayData>();
        // gets the StarData fields of name, RA, dec, spectral type
        data.starData = star;
        // asiigns the star data to the star object

        //checks the data retrieval works:
        Debug.Log("Added star: " + star.name + "spectral type: " + star.spectralType);
             // testing the case switch statement for identifying different spectral types
        if (!string.IsNullOrWhiteSpace(star.spectralType))
        // the string can be null and still exist so this checks the spectral type has letters in it
        {
            switch (star.spectralType[0])
            //otherwise you'd get an out bounds error here
            {
                case 'O':
                    newstar.GetComponent<Renderer>().material.color = new Color(0.0f, 0.7490196f, 1.0f);
                //bright blue
                    break;
                case 'B':
                    newstar.GetComponent<Renderer>().material.color = new Color(0.6784314f, 0.8470589f, 0.9019608f);
                    //white-blue
                    break;
                case 'A':
                    newstar.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
                  //white
                    break;
                case 'F':
                    newstar.GetComponent<Renderer>().material.color = new Color(1f, 1f, 0.8784314f, 1f);
                    //yellow-white
                    break;
                case 'G':
                    newstar.GetComponent<Renderer>().material.color = new Color(1f, 0.92f, 0.016f, 1f);
                    //yellow
                    break;
                case 'K':
                    newstar.GetComponent<Renderer>().material.color = new Color(1f, 0.6470588f, 0f, 1f);
                    //orange
                    break;
                case 'M':
                    newstar.GetComponent<Renderer>().material.color = new Color(1f, 0, 0);
                    //red
                    break;
                case 'T':
                    newstar.GetComponent<Renderer>().material.color = new Color(0.6470588f, 0.1647059f, 0.1647059f, 1f);
                    //brown
                    break;
                case 'Y':
                    newstar.GetComponent<Renderer>().material.color = new Color(0.6470588f, 0.1647059f, 0.1647059f, 1f);
                   //brown
                    break;
                default:

                    break;


            }
        }
    }

}