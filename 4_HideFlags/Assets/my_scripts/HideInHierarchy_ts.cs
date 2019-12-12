using UnityEngine;
using System.Collections;

public class HideInHierarchy_ts : MonoBehaviour
{
    public GameObject go, sub;
    public Transform t;
    void Awake()
    {
        //go��sub��gameObjectΪ�Ѵ��ڶ�������Awake������ʹ��HideFlags.HideInHierarchy
        go.hideFlags = HideFlags.HideInHierarchy;
        sub.hideFlags = HideFlags.HideInHierarchy;
        gameObject.hideFlags = HideFlags.HideInHierarchy;
    }

    void Start()
    {
        //Pl��tf���ڴ����д����Ķ��󣬿������κη�����ʹ��HideFlags.HideInHierarchy
        GameObject Pl = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Pl.hideFlags = HideFlags.HideInHierarchy;
        Transform tf = Instantiate(t, go.transform.position + new Vector3(2, 0.0f, 0.0f), Quaternion.identity) as Transform;
        tf.hideFlags = HideFlags.HideInHierarchy;
    }
}
