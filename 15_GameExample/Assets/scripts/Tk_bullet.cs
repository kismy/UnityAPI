using UnityEngine;
using System.Collections;
//̹���ӵ�
public class Tk_bullet : MonoBehaviour {
    float this_time = 0.0f;
    public Transform tk_exp;//��ըЧ���齨
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
