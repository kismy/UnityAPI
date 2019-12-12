using UnityEngine;
using System.Collections;

public class NewScene_ts : MonoBehaviour {
	void Start () {
        Debug.Log("这是NewScene！");
        //导入名为newScene_unity2的新scene
        Application.LoadLevel("newScene2_unity");
	}
}
