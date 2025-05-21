using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class PhotoCapture : MonoBehaviour
{
    public List<GameObject> headList;


    void Start()
    {
        VuforiaApplication.Instance.OnVuforiaStarted += OnVuforiaStarted;
    }

    void OnVuforiaStarted()
    {
        VuforiaBehaviour.Instance.CameraDevice.SetFrameFormat(PixelFormat.RGB888, true);
    }

    public void CapturePhotoAndApply()
    {
        Vuforia.Image image = VuforiaBehaviour.Instance.CameraDevice.GetCameraImage(PixelFormat.RGB888);

        int width = image.Width;
        int height = image.Height;
        byte[] pixels = image.Pixels;

        Texture2D original = new Texture2D(width, height, TextureFormat.RGB24, false);
        original.LoadRawTextureData(pixels);
        original.Apply();


        Texture2D rotated = new Texture2D(height, width, TextureFormat.RGB24, false);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                rotated.SetPixel(y, width - x - 1, original.GetPixel(x, y));
            }
        }
        rotated.Apply();
        
        foreach(GameObject head in headList)
        {
            Material[] materials = head.GetComponent<Renderer>().materials;
            for (int i = 0; i < materials.Length; i++)
            {
                if (materials[i].name.Contains("visage"))
                {
                    materials[i].mainTexture = rotated;
                    break;
                }
            }
        }
       

        
    }
}
