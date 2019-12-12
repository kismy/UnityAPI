using UnityEngine;
using System.Collections;

public class Seed_ts : MonoBehaviour
{
    void Start()
    {
        //设置随机数的种子
        //不同的种子产生不同的随机数序列
        //对于相同的种子，在程序每次启动时其序列是相同的
        Random.seed = 1;
    }
    void Update()
    {
        Debug.Log(Random.value);
    }
}
