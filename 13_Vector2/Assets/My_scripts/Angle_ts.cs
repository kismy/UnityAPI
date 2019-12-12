using UnityEngine;
using System.Collections;

public class Angle_ts : MonoBehaviour
{
    void Start()
    {
        Debug.Log("1:" + Vector2.Angle(new Vector2(1.0f, 0.0f), new Vector2(-1.0f, 0.0f)));
        Debug.Log("2:" + Vector2.Angle(new Vector2(1.0f, 0.0f), new Vector2(-1.0f, -1.0f)));
        Debug.Log("3:" + Vector2.Angle(new Vector2(0.0f, 0.0f), new Vector2(-1.0f, 0.0f)));
    }
}
