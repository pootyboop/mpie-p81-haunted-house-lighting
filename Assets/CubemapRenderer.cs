using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CubemapRenderer : MonoBehaviour
{
    private static Camera camera;
    private static Cubemap cubemap;

    [MenuItem("Window/RenderCubemap")]
    public static void RenderCubemap ()
    { 

        camera = GameObject.Find("CubemapCam").GetComponent<Camera>();
        cubemap = Resources.Load("Cubemap") as Cubemap;
        camera.RenderToCubemap(cubemap);
        //print(camera.name);
    }
}
