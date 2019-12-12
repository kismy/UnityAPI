using UnityEngine;
using System.Collections;

public class GameObjectAndComponent_ts : MonoBehaviour {
    public GameObject sp;
	void Start () {
        //以下三种表达方式功能一样，都返回当前脚本所在GameObject对象中的Rigidbody组件
        Rigidbody rb1 = rigidbody;
        Rigidbody rb2 = GetComponent<Rigidbody>();
        Rigidbody rb3 = rigidbody.GetComponent<Rigidbody>();
        Debug.Log("rb1的InstanceID：" + rb1.GetInstanceID());
        Debug.Log("rb2的InstanceID：" + rb2.GetInstanceID());
        Debug.Log("rb3的InstanceID：" + rb3.GetInstanceID());

        //使用前置引用获取引用对象的Rigidbody组件
        Debug.Log("前置引用sp对象中Rigidbody的InstanceID："+sp.GetComponent<Rigidbody>().GetInstanceID());
	}
}
