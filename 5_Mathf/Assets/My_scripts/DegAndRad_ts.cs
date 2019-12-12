using UnityEngine;
using System.Collections;

public class DegAndRad_ts : MonoBehaviour {
	void Start () {
        //从角度到弧度转换常量
        Debug.Log("Mathf.Deg2Rad:" + Mathf.Deg2Rad);
        //从弧度到角度转换常量
        Debug.Log("Mathf.Rad2Deg:" + Mathf.Rad2Deg);
	}
}
