using UnityEngine;
using System.Collections;

public class Destroy_ts : MonoBehaviour {
    public GameObject GO,Cube;
	void Start () {
        //5�������GO�����Rigidbody���
        Destroy(GO.rigidbody,5.0f);
        //7�������GO�����е�Destroy_ts�ű�
        Destroy(GO.GetComponent<Destroy_ts>(),7.0f);
        //10�������Cube����ͬʱCube�����������������ཫһ������
        Destroy(Cube, 10.0f);
	}
}
