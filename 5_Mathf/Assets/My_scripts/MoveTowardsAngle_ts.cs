using UnityEngine;
using System.Collections;

public class MoveTowardsAngle_ts : MonoBehaviour
{
    float targets = 0.0f;
    float speed = 40.0f;
    void Update()
    {
        //ÿ֡������speed * Time.deltaTime��
        float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, targets, speed * Time.deltaTime);
        transform.eulerAngles = new Vector3(0, angle, 0);
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "˳ʱ����ת90��"))
        {
            targets += 90.0f;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "��ʱ����ת90��"))
        {
            targets -= 90.0f;
        }
    }
}
