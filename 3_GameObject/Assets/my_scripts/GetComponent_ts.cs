using UnityEngine;
using System.Collections;

public class GetComponent_ts : MonoBehaviour {
	void Start () {
        Debug.Log("������GetComponent�����ʹ�ô��롣\nGetComponent����������ȡ��ǰGameObject�з���Type���͵ĵ�һ�������");
        //GetComponent (type : Type)
        Rigidbody rb = GetComponent(typeof(Rigidbody))as Rigidbody;
        Debug.Log("ʹ��GetComponent (type : Type)��ȡRigidbody��" + rb.GetInstanceID());

        //GetComponent.<T>()
        rb=GetComponent<Rigidbody>();
        Debug.Log("ʹ��GetComponent.<T>()��ȡRigidbody��" + rb.GetInstanceID());

        //GetComponent (type : String)
        rb = GetComponent("Rigidbody") as Rigidbody;
        Debug.Log("ʹ��GetComponent (type : String)��ȡRigidbody��" + rb.GetInstanceID());

        Debug.Log("������GetComponentInChildren�����ʹ�ô��롣\nGetComponentInChildren����������ȡ��ǰGameObject�������������з���Type���͵ĵ�һ�������");

        //GetComponentInChildren (type : Type)
        rb = GetComponentInChildren(typeof(Rigidbody)) as Rigidbody;
        Debug.Log("ʹ��GetComponentInChildren (type : Type)��ȡRigidbody��" + rb.name);

        //GetComponentInChildren.<T> ()
        rb=GetComponentInChildren<Rigidbody>();
        Debug.Log("ʹ��GetComponentInChildren.<T>()��ȡRigidbody��" + rb.name);

        Debug.Log("������GetComponents�����ʹ�ô��롣\nGetComponents����������ȡ��ǰGameObject�з���Type���͵����������");

        //GetComponents (type : Type)
        Component[] cjs = GetComponents(typeof(ConfigurableJoint)) as Component[];
        foreach(ConfigurableJoint cj in cjs){
            Debug.Log("ʹ��GetComponents (type : Type)��ȡConfigurableJoint��" + cj.GetInstanceID());
        }

        //GetComponents.<T> ()
        cjs = GetComponents<ConfigurableJoint>();
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("ʹ��GetComponents.<T>()��ȡConfigurableJoint��" + cj.GetInstanceID());
        }

        Debug.Log("������GetComponentsInChildren�����ʹ�ô��롣\nGetComponentsInChildren����������ȡ��ǰGameObject�������з���Type���͵����������");

        //GetComponentsInChildren(type: Type, includeInactive: boolean = false)
        cjs = GetComponentsInChildren(typeof(ConfigurableJoint), false) as Component[];
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("ʹ��GetComponentsInChildren(type: Type, false)��ȡConfigurableJoint��" + cj.name);
        }

        cjs = GetComponentsInChildren(typeof(ConfigurableJoint), true) as Component[];
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("ʹ��GetComponentsInChildren(type: Type, true)��ȡConfigurableJoint��" + cj.name);
        }

        //GetComponentsInChildren.<T> (includeInactive : boolean)
        cjs = GetComponentsInChildren<ConfigurableJoint>(true);
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("ʹ��GetComponentsInChildren.<T>(includeInactive : boolean)��ȡConfigurableJoint��" + cj.name);
        }

        //GetComponentsInChildren.<T> ()
        cjs = GetComponentsInChildren<ConfigurableJoint>();
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("ʹ��GetComponentsInChildren.<T>()��ȡConfigurableJoint��" + cj.name);
        }
	}
}
