using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
	public bool blueball;
	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "blue"&&variables.colorblue==true)
		{
			if (Input.GetKey(KeyCode.Mouse0))
			{
				//LeanTween.move(other.gameObject, MagnetGo.transform.position, 1.0f).setEase(LeanTweenType.easeOutQuad);
				other.gameObject.GetComponent<FollowMagnet>().enabled = true;
				
			}
			else
			{
				other.gameObject.GetComponent<FollowMagnet>().enabled = false;
				LeanTween.move(other.gameObject, new Vector3(other.gameObject.transform.position.x, 0.33f, other.gameObject.transform.position.z), 1.0f).setEase(LeanTweenType.easeOutQuad);
			}
		}
		if (other.tag == "red" && variables.colorred == true)
		{
			if (Input.GetKey(KeyCode.Mouse0))
			{
				//LeanTween.move(other.gameObject, MagnetGo.transform.position, 1.0f).setEase(LeanTweenType.easeOutQuad);
				other.gameObject.GetComponent<FollowMagnet>().enabled = true;

			}
			else
			{
				other.gameObject.GetComponent<FollowMagnet>().enabled = false;
				LeanTween.move(other.gameObject, new Vector3(other.gameObject.transform.position.x, 0.33f, other.gameObject.transform.position.z), 1.0f).setEase(LeanTweenType.easeOutQuad);
			}
		}
	}
}

