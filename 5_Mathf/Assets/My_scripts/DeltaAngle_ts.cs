using UnityEngine;
using System.Collections;

public class DeltaAngle_ts : MonoBehaviour {
	void Start () {
        //1180=360*3+100,即求100和90之间的夹角
        Debug.Log(Mathf.DeltaAngle(1180, 90));
        //-1130=-360*3-50,即求-50和90之间的夹角
        Debug.Log(Mathf.DeltaAngle(-1130, 90));
        //-1200=-360*3-120,即求-120和90之间的夹角
        Debug.Log(Mathf.DeltaAngle(-1200, 90));
	}
}
