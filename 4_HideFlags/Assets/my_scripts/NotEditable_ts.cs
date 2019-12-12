using UnityEngine;
using System.Collections;

public class NotEditable_ts : MonoBehaviour {
    public GameObject go;
    public Transform t;
    void Start()
    {
        //GameObject对象使用HideFlags.NotEditable可以使得GameObject的
        //所有组件在Inspector面板中都处于不可编辑状态。
        //GameObject对象被HideFlags.NotEditable标识并不影响其子类的可编辑性。
        go.hideFlags = HideFlags.NotEditable;
        GameObject Pl = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Pl.hideFlags = HideFlags.NotEditable;

        //对于GameObject的某个组件单独使用HideFlags.NotEditable，
        //只会使得当前组件不可编辑，但GameObject的其他组件扔可编辑。
        t.hideFlags = HideFlags.NotEditable;
        Transform tf = Instantiate(t, go.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity) as Transform;
        tf.hideFlags = HideFlags.NotEditable;
    }
}
