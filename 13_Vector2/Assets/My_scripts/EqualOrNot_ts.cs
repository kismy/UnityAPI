using UnityEngine;
using System.Collections;

public class EqualOrNot_ts : MonoBehaviour
{
    void Start()
    {
        //A��BС�������λ��ȣ�����λ�㹻�ӽ�ʱ����true
        Vector2 A = new Vector2(1.123453f, 3.123453f);
        Vector2 B = new Vector2(1.123459f, 3.123459f);
        Debug.Log("First:" + (A == B));
        //A��BС�������λ��ȣ�������λ�����ӽ�ʱҲ���ܷ���false
        A = new Vector2(1.123451f, 3.123451f);
        Debug.Log("Second:" + (A == B));
        //A��BС�������λ���ʱһ������true
        A = new Vector2(1.1234560f, 3.1234560f);
        B = new Vector2(1.1234569f, 3.1234569f);
        Debug.Log("Third:" + (A == B));
    }
}
