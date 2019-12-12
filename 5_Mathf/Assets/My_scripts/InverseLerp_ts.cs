using UnityEngine;
using System.Collections;

public class InverseLerp_ts : MonoBehaviour {
	void Start () {
	    float f,from,to,v;
        from=-10.0f;
        to=30.0f;
        v=10.0f;
        f = Mathf.InverseLerp(from,to,v);
        Debug.Log("当0<f'<1时："+f);
        v = -20.0f;
        f = Mathf.InverseLerp(from, to, v);
        Debug.Log("当f'<0时：" + f);
        v = 40.0f;
        f = Mathf.InverseLerp(from, to, v);
        Debug.Log("当f'>1时：" + f);
	}
}
