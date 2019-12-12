using UnityEngine;
using System.Collections;

public class HideInInspector_td : MonoBehaviour {
    public GameObject go;
    public Transform t;
    void Start()
    {
        //go、gameObject、Pl都是GameObject对象，使用HideFlags.HideInInspector后，
        //其所有组件将在Inspector面板中隐藏，
        //但并不影响其子类在Inspector面板中的显示。
        go.hideFlags = HideFlags.HideInInspector;
        gameObject.hideFlags = HideFlags.HideInInspector;
        GameObject Pl = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Pl.hideFlags =  HideFlags.HideInInspector;
        //tf为Transform对象，使用HideFlags.HideInInspector后，
        //tf对应的GameObject的Transform组件将在Inspector面板中隐藏，
        //但GameObject的其他组件扔可在Inspector面板中显示。
        Transform tf = Instantiate(t, go.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity) as Transform;
        tf.hideFlags = HideFlags.HideInInspector;
    }
}
