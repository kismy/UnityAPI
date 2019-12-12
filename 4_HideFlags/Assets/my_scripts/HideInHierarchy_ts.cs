using UnityEngine;
using System.Collections;

public class HideInHierarchy_ts : MonoBehaviour
{
    public GameObject go, sub;
    public Transform t;
    void Awake()
    {
        //go、sub、gameObject为已存在对象，需在Awake方法中使用HideFlags.HideInHierarchy
        go.hideFlags = HideFlags.HideInHierarchy;
        sub.hideFlags = HideFlags.HideInHierarchy;
        gameObject.hideFlags = HideFlags.HideInHierarchy;
    }

    void Start()
    {
        //Pl、tf是在代码中创建的对象，可以在任何方法中使用HideFlags.HideInHierarchy
        GameObject Pl = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Pl.hideFlags = HideFlags.HideInHierarchy;
        Transform tf = Instantiate(t, go.transform.position + new Vector3(2, 0.0f, 0.0f), Quaternion.identity) as Transform;
        tf.hideFlags = HideFlags.HideInHierarchy;
    }
}
