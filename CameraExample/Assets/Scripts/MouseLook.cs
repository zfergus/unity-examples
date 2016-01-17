using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

    private	enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    private RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityX = 2.0f;
    public float sensitivityY = 2.0f;

    public float minimumX = -45.0f;
    public float maximumX = 45.0f;

    public float minimumY = -45.0f;
    public float maximumY = 45.0f;

    float rotationX = 0F;
    float rotationY = 0F;

    void Update ()
    {
        if (axes == RotationAxes.MouseXAndY)
        {
            rotationX += Input.GetAxis("Mouse X") * sensitivityX;
			rotationX  = Mathf.Clamp (rotationX, minimumX, maximumX);

            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY  = Mathf.Clamp (rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
        else if (axes == RotationAxes.MouseX)
        {
            rotationX += Input.GetAxis("Mouse X") * sensitivityX;
			rotationX  = Mathf.Clamp (rotationX, minimumX, maximumX);
			
            transform.Rotate(0, rotationX, 0);
        }
        else
        {
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
        }
    }
}