﻿using UnityEngine;
using UnityEngine.UI;

public class CameraView : MonoBehaviour {

    RawImage rawImage;
    AspectRatioFitter fitter;
    WebCamTexture webcamTexture;
    bool ratioSet;

    void Start() {
        rawImage = GetComponent<RawImage>();
        fitter = GetComponent<AspectRatioFitter>();
        InitWebCam();
    }

    void Update() {

        if (webcamTexture.width > 100 && !ratioSet) {
            ratioSet = true;
            SetAspectRatio();
        }
    }

    void OnDisable()
    {
        // Asegura que la cámara se detenga cuando el objeto se desactive
        if (webcamTexture != null)
        {
            webcamTexture.Stop();
        }
    }

    void OnDestroy()
    {
        // Asegura que la cámara se detenga cuando el objeto sea destruido
        if (webcamTexture != null)
        {
            webcamTexture.Stop();
        }
    }

    void SetAspectRatio() {
        fitter.aspectRatio = (float)webcamTexture.width / (float)webcamTexture.height;
    }

    void InitWebCam() {
        string camName = WebCamTexture.devices[0].name;
        webcamTexture = new WebCamTexture(camName, Screen.width, Screen.height, 30);
        rawImage.texture = webcamTexture;
        webcamTexture.Play();
    }

    public WebCamTexture GetCamImage() {
        return webcamTexture;
    }
}