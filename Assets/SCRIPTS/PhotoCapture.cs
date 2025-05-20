using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class PhotoCapture : MonoBehaviour
{
    public GameObject targetObject;
    public Button captureButton;
    private bool isReady = false;

    void Start()
    {
        VuforiaApplication.Instance.OnVuforiaStarted += OnVuforiaStarted;

        if (captureButton != null)
        {
            captureButton.onClick.AddListener(CapturePhotoAndApply);
        }
    }

    void OnVuforiaStarted()
    {
        VuforiaBehaviour.Instance.CameraDevice.SetFrameFormat(PixelFormat.RGB888, true);
    }

    void CapturePhotoAndApply()
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
                rotated.SetPixel(height - y - 1, x, original.GetPixel(x, y));
            }
        }
        rotated.Apply();

        Renderer rend = targetObject.GetComponent<Renderer>();

        Material[] materials = rend.materials;
        for (int i = 0; i < materials.Length; i++)
        {
            if (materials[i].name.Contains("visage"))
            {
                materials[i].mainTexture = rotated;
                return;
            }
        }
    }
}
