using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
//reference  = 
[SerializeField] GameObject car;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()//
    {
        transform.position = car.transform.position + new Vector3(0,0,-10);
    }
}
