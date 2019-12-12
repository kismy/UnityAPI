using UnityEngine;
using System.Collections;

public class renderingPath_ts : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 120.0f, 45.0f), "UsePlayerSettings"))
        {
            camera.renderingPath = RenderingPath.UsePlayerSettings;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 120.0f, 45.0f), "VertexLit"))
        {
            camera.renderingPath = RenderingPath.VertexLit;
        }
        if (GUI.Button(new Rect(10.0f, 110.0f, 120.0f, 45.0f), "Forward"))
        {
            camera.renderingPath = RenderingPath.Forward;
        }
        if (GUI.Button(new Rect(10.0f, 160.0f, 120.0f, 45.0f), "DeferredLighting"))
        {
            camera.renderingPath = RenderingPath.DeferredLighting;
        }
    }
}
