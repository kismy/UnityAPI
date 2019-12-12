using UnityEngine;
using System.Collections;

public class DontSave_ts : MonoBehaviour {
    public GameObject go;
    public Transform t;
    void Start()
    {
        //GameObject对象使用HideFlags.DontSave可以在新scene中被保留
        go.hideFlags = HideFlags.DontSave;
        GameObject Pl = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Pl.hideFlags = HideFlags.DontSave;
        //不可以对GameObject的组件设置HideFlags.DontSave，否则无效
        Transform tf = Instantiate(t, go.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity) as Transform;
        tf.hideFlags = HideFlags.DontSave;
        //导入名为newScene_unity的新scene
        Application.LoadLevel("newScene2_unity");
    }
}
