using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {
    void Update() {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
