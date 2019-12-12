using UnityEngine;
using System.Collections;

public class ActiveSelf_ts : MonoBehaviour {
    public GameObject cube1, cube2, cube3;
	void Start () {
        //��cube2����Ϊfalse����������Ϊtrue
        cube1.SetActive(true);
        cube2.SetActive(false);
        cube3.SetActive(true);

        Debug.Log("activeSelf:");
        //����cube2������Ϊfalse����������cube3��activeSelf����ֵ��ȻΪtrue
        Debug.Log("cube1.activeSelf:" + cube1.activeSelf);
        Debug.Log("cube2.activeSelf:" + cube2.activeSelf);
        Debug.Log("cube3.activeSelf:" + cube3.activeSelf);

        Debug.Log("\nactiveInHierarchy:");
        //cube2��cube3��activeInHierarchy����ֵ��Ϊfalse��
        Debug.Log("cube1.activeInHierarchy:" + cube1.activeInHierarchy);
        Debug.Log("cube2.activeInHierarchy:" + cube2.activeInHierarchy);
        Debug.Log("cube3.activeInHierarchy:" + cube3.activeInHierarchy);
	}
}
