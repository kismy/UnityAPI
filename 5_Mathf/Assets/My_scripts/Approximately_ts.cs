using UnityEngine;
using System.Collections;

public class Approximately_ts : MonoBehaviour {
	void Start () {
        float[] f={0.0f,2.0f,3.0f};
        bool b1 = (1 ==101/101) ? true : false;
        bool b2 = Mathf.Approximately(1.0f, 10.0f/10.0f);
        Debug.Log("b1:"+b1);
        Debug.Log("b2:" + b2);
        Mathf.Min(f);
	}
}
