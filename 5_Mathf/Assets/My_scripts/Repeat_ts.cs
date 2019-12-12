using UnityEngine;
using System.Collections;

public class Repeat_ts : MonoBehaviour {
	void Start () {
        float f, t, l;
        t = 12.5f;
        l = 5.3f;
        f = Mathf.Repeat(t,l);
        Debug.Log("t>0,l>0时："+f);
        t = -12.5f;
        l = -5.3f;
        f = Mathf.Repeat(t, l);
        Debug.Log("t<0,l<0时：" + f);
        t = 12.5f;
        l = -5.3f;
        f = Mathf.Repeat(t, l);
        Debug.Log("t>0,l<0时：" + f);
        t = -12.5f;
        l = 5.3f;
        f = Mathf.Repeat(t, l);
        Debug.Log("t<0,l>0时：" + f);
        t = -12.5f;
        l = 0.0f;
        f = Mathf.Repeat(t, l);
        Debug.Log("t<0,l==0时：" + f);
	}
}
