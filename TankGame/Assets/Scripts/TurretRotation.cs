using UnityEngine;
using System.Collections;

public class TurretRotation : MonoBehaviour {

	public float rotSpeed = 90.0f;
	
	// Update is called once per frame
	void Update ()
	{
		float step = rotSpeed * Time.deltaTime;

//		if (Input.GetKey (KeyCode.LeftArrow)) {
//			this.transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
//		}
//		else if (Input.GetKey (KeyCode.RightArrow)) {
//			this.transform.Rotate(Vector3.back * rotSpeed * Time.deltaTime);
//		}

		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (mouseRay, out hit, 1 << 8))
		{
			Debug.DrawLine (mouseRay.origin, hit.point);
			Vector3 mouseWorldPos = hit.point;
			mouseWorldPos.y = this.transform.position.y;

			Vector3 targetDir = mouseWorldPos - this.transform.position;
			targetDir = new Vector3(targetDir.x, targetDir.y, targetDir.z);

			Quaternion rotationAngle = Quaternion.LookRotation (targetDir);
			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, 
		                                      rotationAngle, step);
			Debug.DrawLine (this.transform.position, mouseWorldPos);

		}
	}
}
