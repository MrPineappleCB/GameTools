using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PixelArtCamera : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private RawImage rawImage;

    [SerializeField] private int cameraHeight;

    private RenderTexture renderTexture;

    private void Start()
    {
        UpdateRenderTexture();
    }

    public void UpdateRenderTexture()
    {
        if(renderTexture != null)
        {
            renderTexture.Release();
        }

        float aspectRatio = (float)Screen.width / Screen.height;
        int cameraWidth = Mathf.RoundToInt(aspectRatio * cameraHeight);

        renderTexture = new RenderTexture(cameraWidth, cameraHeight, 16, RenderTextureFormat.ARGB32);
        renderTexture.filterMode = FilterMode.Point;

        renderTexture.Create();
        cam.targetTexture = renderTexture;
        rawImage.texture = renderTexture;
    }
}
