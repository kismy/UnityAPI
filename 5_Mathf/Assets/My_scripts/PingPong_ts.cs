using UnityEngine;
using System.Collections;

public class PingPong_ts : MonoBehaviour {
	void Start () {
        float f, t, l;
        t = 11.0f;
        l = 5.0f;
        f = Mathf.PingPong(t,l);
        Debug.Log("l>0,|t|%2l<=l时："+f);
        t = 17.0f;
        l = 5.0f;
        f = Mathf.PingPong(t, l);
        Debug.Log("l>0,|t|%2l>l时：" + f);
        t = 11.0f;
        l = -5.0f;
        f = Mathf.PingPong(t, l);
        Debug.Log("l<0,|t|%2l<=l时：" + f);
        t = 17.0f;
        l = -5.0f;
        f = Mathf.PingPong(t, l);
        Debug.Log("l<0,|t|%2l>l时：" + f);
	}
}
