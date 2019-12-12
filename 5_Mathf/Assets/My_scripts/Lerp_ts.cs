using UnityEngine;
using System.Collections;

public class Lerp_ts : MonoBehaviour {
    float r, g, b;
	void FixedUpdate () {
        r = Mathf.Lerp(0.0f,1.0f,Time.time*0.2f);
        g = Mathf.Lerp(0.0f, 1.0f, -1.0f+Time.time * 0.2f);
        b = Mathf.Lerp(0.0f, 1.0f, -2.0f+Time.time * 0.2f);
        light.color = new Color(r, g, b);
	}
}
