using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float minSize = 10, maxSize = 80;
    public string zoomOutKey = "q", zoomInKey = "e";

    void Start()
    {
        GetComponent<Camera>().orthographicSize = minSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(zoomOutKey))
        {
            GetComponent<Camera>().orthographicSize = GetComponent<Camera>().orthographicSize + 20 * Time.deltaTime;
            if (GetComponent<Camera>().orthographicSize > maxSize)
            {
                GetComponent<Camera>().orthographicSize = maxSize; 
            }
        }


        if (Input.GetKey(zoomInKey)) 
        {
            GetComponent<Camera>().orthographicSize = GetComponent<Camera>().orthographicSize - 20 * Time.deltaTime;
            if (GetComponent<Camera>().orthographicSize < minSize)
            {
                GetComponent<Camera>().orthographicSize = minSize; 
            }
        }
    }
}
