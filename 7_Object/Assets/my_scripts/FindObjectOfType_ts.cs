using UnityEngine;
using System.Collections;

public class FindObjectOfType_ts : MonoBehaviour {
	void Start () {
        GameObject[] gos = FindObjectsOfType(typeof(GameObject)) as GameObject[];
        foreach(GameObject go in gos){
            //1.5������ٳ�������������GameObject
            if (go.name != "Main Camera")
            {
                Destroy(go, 1.5f);
            }
        }

        Rigidbody[] rbs = FindObjectsOfType(typeof(Rigidbody))as Rigidbody[];
        foreach(Rigidbody rb in rbs){
            //���ó�����������и����������Ӧ
            if(rb.name!="Sphere"){
                rb.useGravity = true;
            }
        }
	}
}
