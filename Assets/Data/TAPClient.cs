using UnityEngine;
using System.Collections;
using UnityEngine.Networking;


public class TAPClient : MonoBehaviour
{
    public StarDataReader datareader;
    //we've made an object that can split the returned csv text from the request into individual data values
    void Start()
    {
        Debug.Log("TAP started");
        StartCoroutine(GetText());
    }
    //IEnumerator means that the method can pause - useful for asynchronous queries where program waits

    IEnumerator GetText()
    {
        string query = "SELECT TOP 100 MAIN_ID, RA, DEC, sp_type " + "FROM BASIC " + "WHERE plx_value > 0 " + "AND otype = 'star..' " + "ORDER BY plx_value DESC";
        //this is the query itself for 100 stars closest to us, returns the name, right ascension, and declination
       string webaddress =
    "https://simbad.cfa.harvard.edu/simbad/sim-tap/sync?request=doQuery&lang=adql&format=csv&query="
    + UnityWebRequest.EscapeURL(query);
        UnityWebRequest request = UnityWebRequest.Get(webaddress);
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(request.error);
            Debug.Log("request failed");
        }
        else
        {
            Debug.Log(request.downloadHandler.text);
            string datafile = request.downloadHandler.text;
            datareader.ReadStarData(datafile);

            if (datareader == null)
            {
                Debug.LogError("not assigned");
                yield break;
            }

        }

    }
}

