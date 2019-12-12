using UnityEngine;
using System.Collections;

public class ts : MonoBehaviour {
	void Start () {
        Rigidbody rb1 = rigidbody;
        Rigidbody rb2 = GetComponent<Rigidbody>();
        Rigidbody rb3 = rigidbody.GetComponent<Rigidbody>();
        Debug.Log(rb1.GetInstanceID());
        Debug.Log(rb2.GetInstanceID());
        Debug.Log(rb3.GetInstanceID());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
