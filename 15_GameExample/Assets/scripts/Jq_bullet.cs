using UnityEngine;
using System.Collections;

/**
 * ��ǹ�ӵ�
 * */

public class Jq_bullet : MonoBehaviour
{
    public Transform tk_exp;//��ըЧ�����
    float this_time = 0.0f;
    void Start()
    {
        this_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //����ӵ�4����δ�����壬���Զ����٣������ڴ��˷�
        if (Time.time - this_time > 4.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        //�ӵ���ÿ��100���ٶ���ֲ�forward�����˶�
        transform.rigidbody.velocity = transform.TransformDirection(Vector3.forward * 100);
    }

    void OnTriggerEnter(Collider otherObject)
    {
        //��ըЧ�������ٶ���
        Instantiate(tk_exp, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
