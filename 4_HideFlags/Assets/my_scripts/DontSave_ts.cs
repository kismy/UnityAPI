using UnityEngine;
using System.Collections;

public class DontSave_ts : MonoBehaviour {
    public GameObject go;
    public Transform t;
    void Start()
    {
        //GameObject����ʹ��HideFlags.DontSave��������scene�б�����
        go.hideFlags = HideFlags.DontSave;
        GameObject Pl = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Pl.hideFlags = HideFlags.DontSave;
        //�����Զ�GameObject���������HideFlags.DontSave��������Ч
        Transform tf = Instantiate(t, go.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity) as Transform;
        tf.hideFlags = HideFlags.DontSave;
        //������ΪnewScene_unity����scene
        Application.LoadLevel("newScene2_unity");
    }
}
