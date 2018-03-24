using UnityEngine;
using System.Collections;

public class Screenshot : MonoBehaviour {
    void Update() {
        if(Time.frameCount % 10 == 0){
            string fileName = "screenshots/" + (Time.frameCount / 10) + ".png";
            ScreenCapture.CaptureScreenshot(fileName);
        }
    }
}
