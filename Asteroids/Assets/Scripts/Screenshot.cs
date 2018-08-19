using UnityEngine;
using System.Collections;

public class Screenshot : MonoBehaviour {
    void Update() {
        if (Input.GetKey (KeyCode.E)){
            string filename = "screenshots/" + (Time.frameCount / 10) + ".png";
            ScreenCapture.CaptureScreenshot(filename, 4);
        }
    }
}
