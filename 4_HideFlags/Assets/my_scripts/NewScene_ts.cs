using UnityEngine;
using System.Collections;

public class NewScene_ts : MonoBehaviour {
	void Start () {
        Debug.Log("����NewScene��");
        //������ΪnewScene_unity2����scene
        Application.LoadLevel("newScene2_unity");
	}
}
