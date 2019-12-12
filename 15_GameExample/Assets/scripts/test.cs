using UnityEngine;
using System.Collections;
using System.IO;
public class test : MonoBehaviour {
    
    void Start()
    {
       
    }
    

    void Update() {

        float f = Vector3.Angle(transform.right,Vector3.up);
        Debug.Log(f);
    }
    
    void FixedUpdate()
    {
       
        
    }
    
   
}
