using UnityEngine;
using System.Collections;

public class Instantiate_ts : MonoBehaviour {
    public GameObject A;
    public Transform B;
    public Rigidbody C;
	void Start () {
        Object g1 = Instantiate(A,Vector3.zero,Quaternion.identity) as Object;
        Debug.Log("��¡һ��Object����g1:"+g1);
        GameObject g2 = Instantiate(A, Vector3.zero, Quaternion.identity) as GameObject;
        Debug.Log("��¡һ��GameObject����g2:" + g2);
        Transform t1 = Instantiate(B, Vector3.zero, Quaternion.identity) as Transform;
        Debug.Log("��¡һ��Transform����t1:" + t1);
        Rigidbody r1 = Instantiate(C, Vector3.zero, Quaternion.identity) as Rigidbody;
        Debug.Log("��¡һ��Rigidbody����r1:" + r1);
	}
}
