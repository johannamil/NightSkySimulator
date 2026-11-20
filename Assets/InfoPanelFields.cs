using UnityEngine;
using TMPro;

public class InfoPanelFields : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI RA;
    public TextMeshProUGUI dec;

    public TextMeshProUGUI SPtype;

    public void GetFields(StarData star)
    {
        Name.text = "Name: " + star.name;
        RA.text = "RA: " + star.rightAscension.ToString();
        dec.text = "dec: " + star.declination.ToString();
        SPtype.text = "sp type: " + star.spectralType.ToString();

    }

}
