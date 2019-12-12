using UnityEngine;
using System.Collections;

public class Destroy_ts : MonoBehaviour {
    public GameObject GO,Cube;
	void Start () {
        //5秒后销毁GO对象的Rigidbody组件
        Destroy(GO.rigidbody,5.0f);
        //7秒后销毁GO对象中的Destroy_ts脚本
        Destroy(GO.GetComponent<Destroy_ts>(),7.0f);
        //10秒后销毁Cube对象，同时Cube对象的所有组件及子类将一并销毁
        Destroy(Cube, 10.0f);
	}
}
