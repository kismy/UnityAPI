using UnityEngine;
using System.Collections;

public class Round_ts : MonoBehaviour
{
    void Start()
    {
        //设Round(f)中f=a.b
        Debug.Log("b<0.5,f>0：" + Mathf.Round(2.49f));
        Debug.Log("b<0.5,f<0：" + Mathf.Round(-2.49f));
        Debug.Log("b>0.5,f>0：" + Mathf.Round(2.61f));
        Debug.Log("b>0.5,f<0：" + Mathf.Round(-2.61f));
        Debug.Log("b=0.5,a为偶数，f>0：" + Mathf.Round(6.5f));
        Debug.Log("b=0.5,a为偶数,f<0：" + Mathf.Round(-6.5f));
        Debug.Log("b=0.5,a为奇数,f>0：" + Mathf.Round(7.5f));
        Debug.Log("b=0.5,a为奇数,f<0：" + Mathf.Round(-7.5f));
    }
}
