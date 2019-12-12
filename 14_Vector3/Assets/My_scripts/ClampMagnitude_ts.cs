using UnityEngine;
using System.Collections;

public class ClampMagnitude_ts : MonoBehaviour {
	void Start () {
        Vector3 ts = new Vector3(1.0f,2.0f,3.0f);
        Debug.Log("ts的单位向量为："+ts.normalized+" ts模长为："+ts.magnitude);

        Debug.Log("当f值大于ts模长时：");
        float f = ts.magnitude + 1.0f;
        Vector3 ov = Vector3.ClampMagnitude(ts,f);
        Debug.Log("ov向量:" + ov.ToString()+"其单位向量为："+ov.normalized + " ov的模长为:" + ov.magnitude);

        Debug.Log("当f值小于ts模长时：");
        f = ts.magnitude - 1.0f;
        ov = Vector3.ClampMagnitude(ts,f);
        Debug.Log("ov向量:" + ov.ToString() + "其单位向量为：" + ov.normalized + " ov的模长为:" + ov.magnitude);
	}
}
