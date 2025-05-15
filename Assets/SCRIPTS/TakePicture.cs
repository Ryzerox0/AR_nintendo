using UnityEngine;
using UnityEngine.UI;

public class TakePicture : MonoBehaviour
{
    public RawImage display;
    private WebCamTexture webCam;
    public Texture2D picture;

    void Start()
    {
        webCam = new WebCamTexture();
        display.texture = webCam;
        display.material.mainTexture = webCam;
        webCam.Play();
    }

    public Texture2D CapturePhoto()
    {
        Texture2D photo = new Texture2D(webCam.width, webCam.height);
        photo.SetPixels(webCam.GetPixels());
        photo.Apply();
        return photo;
    }

    public void TakePhoto()
    {
        picture = CapturePhoto();
    }
}
