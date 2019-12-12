using UnityEngine;
using System.Collections;

public class LerpAngle_ts : MonoBehaviour {
	void Start () {
        float a, b;
        a = -50.0f;
        b = 400.0f;
        //a'=360-50=310,b'=-360+400=40,从而可知c=90，
        //从a'沿着逆时针方向可经90度到b'，故返回值f=a+c*t=-50+90*0.3=-23
        Debug.Log("test1:"+Mathf.LerpAngle(a,b,0.3f));

        a = 400.0f;
        b = -50.0f;
        //a'=-360+400=40,b'=360-50=310,从而可知c=90，
        //从a'沿着顺时针方向可经90度到b'，故返回值f=a-c*t=400-90*0.3=373
        Debug.Log("test2:" + Mathf.LerpAngle(a, b, 0.3f));
	}
}
