using UnityEngine;
using System.Collections;

public class EqualOrNot_ts : MonoBehaviour
{
    void Start()
    {
        Vector3 v1 = new Vector3(1.123451f, 2.123451f, 3.123451f);
        Vector3 v2 = new Vector3(1.123452f, 2.123452f, 3.123452f);
        if (v1 == v2)
        {
            Debug.Log("v1==v2");
        }
        else
        {
            Debug.Log("v1!=v2");
        }
    }
}
