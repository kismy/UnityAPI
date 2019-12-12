using UnityEngine;
using System.Collections;
//坦克子弹
public class Tk_bullet : MonoBehaviour {
    float this_time = 0.0f;
    public Transform tk_exp;//爆炸效果组建
	void Start () {
        this_time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time-this_time>5.0f){
            Destroy(this.gameObject);
        }
	}

    void FixedUpdate() {
        transform.rigidbody.velocity =transform.TransformDirection(Vector3.forward*60);
    }

    void OnTriggerEnter(Collider otherObject)
    {
        Instantiate(tk_exp, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
