using UnityEngine;
using System.Collections;

public class InverseLerp_ts : MonoBehaviour {
	void Start () {
	    float f,from,to,v;
        from=-10.0f;
        to=30.0f;
        v=10.0f;
        f = Mathf.InverseLerp(from,to,v);
        Debug.Log("��0<f'<1ʱ��"+f);
        v = -20.0f;
        f = Mathf.InverseLerp(from, to, v);
        Debug.Log("��f'<0ʱ��" + f);
        v = 40.0f;
        f = Mathf.InverseLerp(from, to, v);
        Debug.Log("��f'>1ʱ��" + f);
	}
}
