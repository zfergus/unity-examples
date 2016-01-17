using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlideFanSpeed : MonoBehaviour
{
	private Slider fanSlider;

	void Start()
	{
		this.fanSlider = this.GetComponent<Slider> ();
		if(fanSlider == null)
		{
			Debug.LogWarning("SliderFanSpeed script applied to object that does not contain a Slider component, " + this.gameObject.name);
		}
		this.ChangeFanSpeed ();
		this.ChangeHoverzoneSize ();
	}

	public void ChangeFanSpeed()
	{
		if (this.fanSlider != null)
		{
			GameObject fan = GameObject.FindGameObjectWithTag ("Fan");
			if (fan != null)
			{
				FanSpin fanSpin = fan.GetComponent<FanSpin>();
				if(fanSpin != null)
				{
					fanSpin.SetRotationalSpeed(fanSlider.value);
				}
				else
				{
					Debug.LogWarning("Fan object, " + fan.name + ", missing FanSpin script.");
				}
			}
			else
			{
				Debug.LogWarning("No object tagged as Fan found in the scene.");
			}
		}
	}
	
	public void ChangeHoverzoneSize()
	{
		if (fanSlider != null)
		{
			GameObject hoverzone = GameObject.FindGameObjectWithTag ("HoverZone");
			if (hoverzone != null)
			{
				BoxCollider boxCollider = hoverzone.GetComponent<BoxCollider>();
				if(boxCollider != null)
				{
					boxCollider.size = new Vector3(boxCollider.size.x, (fanSlider.value/100.0f), boxCollider.size.z);
					boxCollider.center = new Vector3(boxCollider.center.x, (boxCollider.size.y / 2.0f), boxCollider.center.z);
				}
				else
				{
					Debug.LogWarning("HoverZone object, " + hoverzone.name + ", missing BoxCollider.");
				}
			}
			else
			{
				Debug.LogWarning("No object tagged as HoverZone found in the scene.");
			}
		}
	}
}
