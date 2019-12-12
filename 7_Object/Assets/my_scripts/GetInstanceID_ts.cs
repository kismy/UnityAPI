using UnityEngine;
using System.Collections;

public class GetInstanceID_ts : MonoBehaviour {
	void Start () {
        Debug.Log("gameObject的ID："+gameObject.GetInstanceID());
        Debug.Log("transform的ID："+transform.GetInstanceID());

        GameObject g1, g2;
        //从GameObject创建一个对象
        g1=GameObject.CreatePrimitive(PrimitiveType.Cube);
        //克隆对象
        g2=Instantiate(g1,Vector3.zero,Quaternion.identity)as GameObject;

        Debug.Log("GameObject g1的ID："+g1.GetInstanceID());
        Debug.Log("Transform g1的ID："+g1.transform.GetInstanceID());

        Debug.Log("GameObject g2的ID：" + g2.GetInstanceID());
        Debug.Log("Transform g2的ID：" + g2.transform.GetInstanceID());
	}
}
