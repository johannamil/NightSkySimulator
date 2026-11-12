using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Camera camera;
    private Vector3 previouspos;
    private Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse clicked");
            previouspos = camera.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 newpos = camera.ScreenToViewportPoint(Input.mousePosition);
            direction = previouspos - newpos;
            previouspos = newpos;

            float rotationy = -direction.y * 180; // camera moves horizontally
            float rotationx = direction.x * 180; // camera moves vertically
        
            camera.transform.Rotate(new Vector3(1, 0, 0), rotationy);
            camera.transform.Rotate(new Vector3(0, 1, 0), rotationx, Space.World);
        }   
    }
}
