using UnityEngine;
using System.Collections;

public class DeltaAngle_ts : MonoBehaviour {
	void Start () {
        //1180=360*3+100,����100��90֮��ļн�
        Debug.Log(Mathf.DeltaAngle(1180, 90));
        //-1130=-360*3-50,����-50��90֮��ļн�
        Debug.Log(Mathf.DeltaAngle(-1130, 90));
        //-1200=-360*3-120,����-120��90֮��ļн�
        Debug.Log(Mathf.DeltaAngle(-1200, 90));
	}
}
