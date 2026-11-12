using UnityEngine;

public class StarClick : MonoBehaviour
{
    private Ray ray;
    private RaycastHit click;
    public Camera camera;
    public GameObject infopanel;
    public GameObject clickedstar;
    public InfoPanelFields datafields;


    void Update()
    {
        if (Clicked())
        {
            Vector3 clickpos = Input.mousePosition;
            clickpos.y = clickpos.y + 100f;
            clickpos.x = clickpos.x + 100f;
            infopanel.SetActive(true);
            infopanel.transform.position = clickpos;

            clickedstar = click.collider.gameObject;
            DisplayData dataobject = clickedstar.GetComponent<DisplayData>();
            if (dataobject != null)
            {
                datafields.GetFields(dataobject.starData);
            }
            else{ Debug.Log("null"); }

        }

    }

    public bool Clicked()
    {
        if (Input.GetMouseButtonDown(0))
        {

            ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out click, Mathf.Infinity))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        return false;
    }
}