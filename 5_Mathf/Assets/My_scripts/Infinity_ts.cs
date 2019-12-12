using UnityEngine;
using System.Collections;

public class Infinity_ts : MonoBehaviour
{
    void Start()
    {
        Debug.Log("0:" + Mathf.Infinity);
        Debug.Log("1:" + Mathf.Infinity / 10000.0f);
        Debug.Log("2:" + Mathf.Infinity / Mathf.Infinity);
    }
}
