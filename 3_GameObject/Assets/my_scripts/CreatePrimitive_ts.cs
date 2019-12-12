using UnityEngine;
using System.Collections;

public class CreatePrimitive_ts : MonoBehaviour
{
    void Start()
    {
        //ʹ��GameObject.CreatePrimitive��������GameObject
        GameObject g1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        g1.name = "G1";
        g1.tag = "sphere_Tag";
        //ʹ�� AddComponent (className : String)����������
        g1.AddComponent("SpringJoint");
        //ʹ��AddComponent (componentType : Type)����������
        g1.AddComponent(typeof(GUITexture));
        g1.transform.position = Vector3.zero;

        GameObject g2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        g2.name = "G2";
        g2.tag = "sphere_Tag";
        //ʹ��AddComponent.<T>()����������
        g2.AddComponent<Rigidbody>();
        g2.transform.position = 2.0f * Vector3.right;
        g2.GetComponent<Rigidbody>().useGravity = false;

        GameObject g3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        g3.name = "G1";
        g3.tag = "sphere_Tag";
        g3.transform.position = 4.0f * Vector3.right;

        //ʹ��GameObject.Find�෽����ȡGameObject�����ط��������ĵ�һ������
        Debug.Log("use Find:" + GameObject.Find("G1").transform.position);
        //ʹ��GameObject.FindGameObjectWithTag�෽����ȡGameObject�����ط��������ĵ�һ������
        Debug.Log("use FindGameObjectWithTag:" + GameObject.FindGameObjectWithTag("sphere_Tag").transform.position);
        //ʹ��GameObject.FindGameObjectsWithTag�෽����ȡGameObject�����ط������������ж���
        GameObject[] gos = GameObject.FindGameObjectsWithTag("sphere_Tag");
        foreach (GameObject go in gos)
        {
            Debug.Log("use FindGameObjectsWithTag:" + go.name + ":" + go.transform.position);
        }

        g3.transform.parent = g2.transform;
        g2.transform.parent = g1.transform;

        Debug.Log("use Find again1:" + GameObject.Find("G1").transform.position);
        //ʹ�ô�"/"�޶������ķ�ʽ����GameObject��
        //�˴����صĶ������丸��ΪG2����G2�ĸ�����ΪG1,
        //ע�������治��"/"�޶��������صĶ��������
        Debug.Log("use Find again2:" + GameObject.Find("/G1/G2/G1").transform.position);
    }
}
