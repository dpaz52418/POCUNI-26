using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        // Ensure mouseObject's location follows my mouse
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; // Set this to be the distance from the camera to the object
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(worldPosition.x, worldPosition.y, transform.position.z);
        

        
    }

}
