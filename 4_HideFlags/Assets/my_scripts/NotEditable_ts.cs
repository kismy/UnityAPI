using UnityEngine;
using System.Collections;

public class NotEditable_ts : MonoBehaviour {
    public GameObject go;
    public Transform t;
    void Start()
    {
        //GameObject����ʹ��HideFlags.NotEditable����ʹ��GameObject��
        //���������Inspector����ж����ڲ��ɱ༭״̬��
        //GameObject����HideFlags.NotEditable��ʶ����Ӱ��������Ŀɱ༭�ԡ�
        go.hideFlags = HideFlags.NotEditable;
        GameObject Pl = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Pl.hideFlags = HideFlags.NotEditable;

        //����GameObject��ĳ���������ʹ��HideFlags.NotEditable��
        //ֻ��ʹ�õ�ǰ������ɱ༭����GameObject����������ӿɱ༭��
        t.hideFlags = HideFlags.NotEditable;
        Transform tf = Instantiate(t, go.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity) as Transform;
        tf.hideFlags = HideFlags.NotEditable;
    }
}
