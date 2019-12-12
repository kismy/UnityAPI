using UnityEngine;
using System.Collections;

public class ActiveSelf_ts : MonoBehaviour {
    public GameObject cube1, cube2, cube3;
	void Start () {
        //对cube2设置为false，其他设置为true
        cube1.SetActive(true);
        cube2.SetActive(false);
        cube3.SetActive(true);

        Debug.Log("activeSelf:");
        //尽管cube2被设置为false，但其子类cube3的activeSelf返回值仍然为true
        Debug.Log("cube1.activeSelf:" + cube1.activeSelf);
        Debug.Log("cube2.activeSelf:" + cube2.activeSelf);
        Debug.Log("cube3.activeSelf:" + cube3.activeSelf);

        Debug.Log("\nactiveInHierarchy:");
        //cube2和cube3的activeInHierarchy返回值都为false。
        Debug.Log("cube1.activeInHierarchy:" + cube1.activeInHierarchy);
        Debug.Log("cube2.activeInHierarchy:" + cube2.activeInHierarchy);
        Debug.Log("cube3.activeInHierarchy:" + cube3.activeInHierarchy);
	}
}
