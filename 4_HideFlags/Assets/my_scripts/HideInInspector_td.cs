using UnityEngine;
using System.Collections;

public class HideInInspector_td : MonoBehaviour {
    public GameObject go;
    public Transform t;
    void Start()
    {
        //go��gameObject��Pl����GameObject����ʹ��HideFlags.HideInInspector��
        //�������������Inspector��������أ�
        //������Ӱ����������Inspector����е���ʾ��
        go.hideFlags = HideFlags.HideInInspector;
        gameObject.hideFlags = HideFlags.HideInInspector;
        GameObject Pl = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Pl.hideFlags =  HideFlags.HideInInspector;
        //tfΪTransform����ʹ��HideFlags.HideInInspector��
        //tf��Ӧ��GameObject��Transform�������Inspector��������أ�
        //��GameObject����������ӿ���Inspector�������ʾ��
        Transform tf = Instantiate(t, go.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity) as Transform;
        tf.hideFlags = HideFlags.HideInInspector;
    }
}
