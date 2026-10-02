using UnityEngine;
using System.Collections;
using UnityEngine.Networking;


public class TAPClient : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(GetText());
    }
    //IEnumerator means that the method can pause - useful for asynchronous queries
    IEnumerator GetText()
    {
        UnityWebRequest request = UnityWebRequest.Get("https://simbad.cds.unistra.fr/simbad/sim-tap/sync?request=doQuery&lang=adql&format=csv&query=SELECT TOP 10 MAIN_ID,RA,DEC FROM BASIC WHERE rvz_redshift > 3.3");
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(request.error);
        }
        else
        {
            Debug.Log(request.downloadHandler.text);
        }

    }
}
