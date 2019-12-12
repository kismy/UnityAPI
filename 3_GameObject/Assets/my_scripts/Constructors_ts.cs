using UnityEngine;
using System.Collections;

public class Constructors_ts : MonoBehaviour {
	void Start () {
        //ʹ�ù��캯��GameObject (name : String)
        GameObject g1 = new GameObject("G1");
        g1.AddComponent<Rigidbody>();
        //ʹ�ù��캯��GameObject () 
        GameObject g2 = new GameObject();
        g2.AddComponent<FixedJoint>();
        //ʹ�ù��캯��GameObject (name : String, params components : Type[])
        GameObject g3 = new GameObject("G3",typeof(MeshRenderer),typeof(Rigidbody),typeof(SpringJoint));

        Debug.Log("g1 name:" + g1.name + "\nPosition:" + g1.transform.position);
        Debug.Log("g2 name:" + g2.name + "\nPosition:" + g2.transform.position);
        Debug.Log("g3 name:" + g3.name + "\nPosition:" + g3.transform.position);
	}
}
