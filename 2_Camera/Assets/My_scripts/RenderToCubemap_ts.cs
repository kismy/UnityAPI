using UnityEngine;
using System.Collections;

public class RenderToCubemap_ts : MonoBehaviour
{
    public Cubemap cp;
    void Start()
    {
        camera.RenderToCubemap(cp);
    }
}
