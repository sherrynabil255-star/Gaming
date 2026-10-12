using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public Transform Target;
public float Cameraspeed;
public float minx,maxx;
public float miny,maxy;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
FixedUpdate(){
    if (Target!=null){
        Vector2 newCamPosition=Vector2.Lerp(transform.position,Target.position,Time.deltaTime*Cameraspeed);
    }
}    
Mathf.Clamp(){
    float Clampx=Mathf.Clamp(newCamPosition.x,minx,maxx);
    float Clampx=Mathf.Clamp(newCamPosition.y,miny,maxy);
    transform.position=new Vector3(Clampx,Clampy,-10f);
}

}
