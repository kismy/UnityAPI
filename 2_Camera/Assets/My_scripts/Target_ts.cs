using UnityEngine;
using System.Collections;

public class Target_ts : MonoBehaviour {
    public Transform ts;
	void Update () {
        transform.RotateAround(ts.position,ts.up,30.0f*Time.deltaTime);
	}
}
