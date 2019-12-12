using UnityEngine;
using System.Collections;

public class Project_ts : MonoBehaviour {
    public Transform from_T, to_T;
    Vector3 projects = Vector3.zero;

    void Update()
    {
        projects = Vector3.Project(from_T.position, to_T.position);

        Debug.DrawLine(Vector3.zero, projects, Color.black);
        Debug.DrawLine(Vector3.zero, from_T.position, Color.red);
        Debug.DrawLine(Vector3.zero, to_T.position, Color.yellow);
    }
}
