using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraZoom : MonoBehaviour
{

private Camera Cam;
public float targetzoom = 3;
private float scrolldata;
public float zoomspeed = 3;
    // Start is called before the first frame update
    void Start()
    {
       Cam=GetComponent<Camera>();
       targetzoom= Cam.orthographicSize; 
    }

    // Update is called once per frame
    void Update()
    {
        scrolldata=Input.GetAxis("Mouse ScrollWheel");
        targetzoom = targetzoom - scrolldata;
    } 

targetzoom=Mathf.Clamp(targetzoom,3,6);

Cam.orthographicSize=Mathf.Lerp(Cam.orthographicSize,targetzoom,Time.deltaTime*zoomspeed);
}
