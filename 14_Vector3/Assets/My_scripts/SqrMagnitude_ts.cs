using UnityEngine;
using System.Collections;

public class SqrMagnitude_ts : MonoBehaviour {
	void Start () {
        Vector3 v1 = new Vector3(3.0f,4.0f,5.0f);
        Vector3 v2 = new Vector3(1.0f, 2.0f, 8.0f);
        Debug.Log("向量v1的长度："+v1.magnitude);
        Debug.Log("向量v2的长度："+v2.magnitude);
        float f1 = v1.sqrMagnitude;
        float f2 = v2.sqrMagnitude;
        Debug.Log("v1模长的平方值：" + f1 + "  v2模长的平方值：" + f2);
        if(f1 == f2){
            Debug.Log("向量v1和v2的模长一样大！");
        }
        else if (f1 > f2)
        {
            Debug.Log("向量v1的模长比较大！");
        }else{
            Debug.Log("向量v2的模长比较大！");
        }
	}
}
