using UnityEngine;
using System.Collections;

public class EqualOrNot_ts : MonoBehaviour
{
    void Start()
    {
        //A、B小数点后五位相等，第六位足够接近时返回true
        Vector2 A = new Vector2(1.123453f, 3.123453f);
        Vector2 B = new Vector2(1.123459f, 3.123459f);
        Debug.Log("First:" + (A == B));
        //A、B小数点后五位相等，但第六位不够接近时也可能返回false
        A = new Vector2(1.123451f, 3.123451f);
        Debug.Log("Second:" + (A == B));
        //A、B小数点后六位相等时一定返回true
        A = new Vector2(1.1234560f, 3.1234560f);
        B = new Vector2(1.1234569f, 3.1234569f);
        Debug.Log("Third:" + (A == B));
    }
}
