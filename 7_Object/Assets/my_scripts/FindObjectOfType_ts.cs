using UnityEngine;
using System.Collections;

public class FindObjectOfType_ts : MonoBehaviour {
	void Start () {
        GameObject[] gos = FindObjectsOfType(typeof(GameObject)) as GameObject[];
        foreach(GameObject go in gos){
            //1.5秒后销毁除摄像机外的所有GameObject
            if (go.name != "Main Camera")
            {
                Destroy(go, 1.5f);
            }
        }

        Rigidbody[] rbs = FindObjectsOfType(typeof(Rigidbody))as Rigidbody[];
        foreach(Rigidbody rb in rbs){
            //启用除球体外的所有刚体的重力感应
            if(rb.name!="Sphere"){
                rb.useGravity = true;
            }
        }
	}
}
