using UnityEngine;
using System.Collections;

public class CreatePrimitive_ts : MonoBehaviour
{
    void Start()
    {
        //使用GameObject.CreatePrimitive方法创建GameObject
        GameObject g1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        g1.name = "G1";
        g1.tag = "sphere_Tag";
        //使用 AddComponent (className : String)方法添加组件
        g1.AddComponent("SpringJoint");
        //使用AddComponent (componentType : Type)方法添加组件
        g1.AddComponent(typeof(GUITexture));
        g1.transform.position = Vector3.zero;

        GameObject g2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        g2.name = "G2";
        g2.tag = "sphere_Tag";
        //使用AddComponent.<T>()方法添加组件
        g2.AddComponent<Rigidbody>();
        g2.transform.position = 2.0f * Vector3.right;
        g2.GetComponent<Rigidbody>().useGravity = false;

        GameObject g3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        g3.name = "G1";
        g3.tag = "sphere_Tag";
        g3.transform.position = 4.0f * Vector3.right;

        //使用GameObject.Find类方法获取GameObject，返回符合条件的第一个对象
        Debug.Log("use Find:" + GameObject.Find("G1").transform.position);
        //使用GameObject.FindGameObjectWithTag类方法获取GameObject，返回符合条件的第一个对象
        Debug.Log("use FindGameObjectWithTag:" + GameObject.FindGameObjectWithTag("sphere_Tag").transform.position);
        //使用GameObject.FindGameObjectsWithTag类方法获取GameObject，返回符合条件的所有对象
        GameObject[] gos = GameObject.FindGameObjectsWithTag("sphere_Tag");
        foreach (GameObject go in gos)
        {
            Debug.Log("use FindGameObjectsWithTag:" + go.name + ":" + go.transform.position);
        }

        g3.transform.parent = g2.transform;
        g2.transform.parent = g1.transform;

        Debug.Log("use Find again1:" + GameObject.Find("G1").transform.position);
        //使用带"/"限定条件的方式查找GameObject，
        //此处返回的对象需其父类为G2，且G2的父类名为G1,
        //注意与上面不带"/"限定条件返回的对象的区别。
        Debug.Log("use Find again2:" + GameObject.Find("/G1/G2/G1").transform.position);
    }
}
