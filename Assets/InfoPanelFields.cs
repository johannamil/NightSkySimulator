using UnityEngine;
using TMPro;

public class InfoPanelFields : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI RA;
    public TextMeshProUGUI dec;

    public void GetFields(StarData star)
    {
        Name.text = star.name;
        RA.text = star.rightAscension.ToString();
        dec.text = star.declination.ToString();
    }

}
