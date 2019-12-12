using UnityEngine;
using System.Collections;

public class DontDestoryOnLoad_ts : MonoBehaviour
{
    public GameObject g1, g2;
    public Renderer re1, re2;
    void Start()
    {
        //g1指向一个顶层父物体对象,在导入新Scene时g1被保存
        DontDestroyOnLoad(g1);
        //g2指向一个子类对象，在导入新Scene时会发现g2没有被保存
        DontDestroyOnLoad(g2);
        //re1指向一个顶层父物体的Renderer组件,在导入新Scene时re1被保存
        DontDestroyOnLoad(re1);
        //re2指向一个子类对象的renderer组件，在导入新Scene时会发现re2指向的对象及组件没有被保存
        DontDestroyOnLoad(re2);
        Application.LoadLevel("FindObjectsOfType_unity");
    }
}
