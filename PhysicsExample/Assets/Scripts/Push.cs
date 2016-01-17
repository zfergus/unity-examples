using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Push : MonoBehaviour
{
	public float force = 100;
	private float originalForce;
	
	void Start()
	{
		originalForce = force;
	}
	
	/* Attempts to play the sound clip in the scene. Returns a boolean for if */
	/* the sound clip was played.                                             */
	private bool PlaySoundClip()
	{
		/* Play Sound Clip if able to. */
		
		/* Get the toggle to see if the clip should be played. */
		GameObject toggleObj = 
			GameObject.FindGameObjectWithTag("PlaySoundToggle");
		if(toggleObj != null)
		{
			Toggle soundToggle = toggleObj.GetComponent<Toggle>();
			if(soundToggle != null && soundToggle.isOn)
			{
				/* Attempt to get the audio source and play it. */
				GameObject audioObj = 
					GameObject.FindGameObjectWithTag("SoundClip");
				if(audioObj != null)
				{
					AudioSource soundClip = 
						audioObj.GetComponent<AudioSource>();
					if(soundClip != null && soundClip.clip != null)
					{
						soundClip.Play();
						return true;
					}
				}
			}
		}
		
		return false;
	}
	
	void OnMouseDown()
	{
		/* Try and play the clip then add the force after a second. */
		if(this.PlaySoundClip())
		{
			this.force *= 10;
			Invoke("AddForceFromCamera", 1);
		}
		/* Otherwise just add the force. */
		else
		{
			AddForceFromCamera();
		}
	}
	
	/* Apply a force in the direction from the camera to this position. */
	void AddForceFromCamera()
	{
		/* Determine the direction from the camera to this position. */
		Vector3 dir = this.transform.position - Camera.main.transform.position;
		/* Normalize the direction. */
		dir.Normalize();
		
		/* Apply a force in the direction. */
		this.GetComponent<Rigidbody>().AddForce (dir * this.force);
		
		/* Reset the force to the original force. */
		this.force = originalForce;
	}
}
