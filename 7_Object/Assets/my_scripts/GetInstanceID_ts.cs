using UnityEngine;
using System.Collections;

public class GetInstanceID_ts : MonoBehaviour {
	void Start () {
        Debug.Log("gameObject��ID��"+gameObject.GetInstanceID());
        Debug.Log("transform��ID��"+transform.GetInstanceID());

        GameObject g1, g2;
        //��GameObject����һ������
        g1=GameObject.CreatePrimitive(PrimitiveType.Cube);
        //��¡����
        g2=Instantiate(g1,Vector3.zero,Quaternion.identity)as GameObject;

        Debug.Log("GameObject g1��ID��"+g1.GetInstanceID());
        Debug.Log("Transform g1��ID��"+g1.transform.GetInstanceID());

        Debug.Log("GameObject g2��ID��" + g2.GetInstanceID());
        Debug.Log("Transform g2��ID��" + g2.transform.GetInstanceID());
	}
}
