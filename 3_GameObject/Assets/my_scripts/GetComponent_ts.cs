using UnityEngine;
using System.Collections;

public class GetComponent_ts : MonoBehaviour {
	void Start () {
        Debug.Log("以下是GetComponent的相关使用代码。\nGetComponent方法用来获取当前GameObject中符合Type类型的第一个组件。");
        //GetComponent (type : Type)
        Rigidbody rb = GetComponent(typeof(Rigidbody))as Rigidbody;
        Debug.Log("使用GetComponent (type : Type)获取Rigidbody：" + rb.GetInstanceID());

        //GetComponent.<T>()
        rb=GetComponent<Rigidbody>();
        Debug.Log("使用GetComponent.<T>()获取Rigidbody：" + rb.GetInstanceID());

        //GetComponent (type : String)
        rb = GetComponent("Rigidbody") as Rigidbody;
        Debug.Log("使用GetComponent (type : String)获取Rigidbody：" + rb.GetInstanceID());

        Debug.Log("以下是GetComponentInChildren的相关使用代码。\nGetComponentInChildren方法用来获取当前GameObject的所有子类中中符合Type类型的第一个组件。");

        //GetComponentInChildren (type : Type)
        rb = GetComponentInChildren(typeof(Rigidbody)) as Rigidbody;
        Debug.Log("使用GetComponentInChildren (type : Type)获取Rigidbody：" + rb.name);

        //GetComponentInChildren.<T> ()
        rb=GetComponentInChildren<Rigidbody>();
        Debug.Log("使用GetComponentInChildren.<T>()获取Rigidbody：" + rb.name);

        Debug.Log("以下是GetComponents的相关使用代码。\nGetComponents方法用来获取当前GameObject中符合Type类型的所有组件。");

        //GetComponents (type : Type)
        Component[] cjs = GetComponents(typeof(ConfigurableJoint)) as Component[];
        foreach(ConfigurableJoint cj in cjs){
            Debug.Log("使用GetComponents (type : Type)获取ConfigurableJoint：" + cj.GetInstanceID());
        }

        //GetComponents.<T> ()
        cjs = GetComponents<ConfigurableJoint>();
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("使用GetComponents.<T>()获取ConfigurableJoint：" + cj.GetInstanceID());
        }

        Debug.Log("以下是GetComponentsInChildren的相关使用代码。\nGetComponentsInChildren方法用来获取当前GameObject的子类中符合Type类型的所有组件。");

        //GetComponentsInChildren(type: Type, includeInactive: boolean = false)
        cjs = GetComponentsInChildren(typeof(ConfigurableJoint), false) as Component[];
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("使用GetComponentsInChildren(type: Type, false)获取ConfigurableJoint：" + cj.name);
        }

        cjs = GetComponentsInChildren(typeof(ConfigurableJoint), true) as Component[];
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("使用GetComponentsInChildren(type: Type, true)获取ConfigurableJoint：" + cj.name);
        }

        //GetComponentsInChildren.<T> (includeInactive : boolean)
        cjs = GetComponentsInChildren<ConfigurableJoint>(true);
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("使用GetComponentsInChildren.<T>(includeInactive : boolean)获取ConfigurableJoint：" + cj.name);
        }

        //GetComponentsInChildren.<T> ()
        cjs = GetComponentsInChildren<ConfigurableJoint>();
        foreach (ConfigurableJoint cj in cjs)
        {
            Debug.Log("使用GetComponentsInChildren.<T>()获取ConfigurableJoint：" + cj.name);
        }
	}
}
