using UnityEngine;
using System.Collections;

public class FollowMagnet : MonoBehaviour
{
	public GameObject player;     
	private Vector3 offset;
	public GameObject MagnetGo;

	void Start()
	{
		offset = transform.position - player.transform.position;
	}

	void Update()
	{


		//LeanTween.moveY(this.gameObject, player.transform.position.y, 1.0f).setEase(LeanTweenType.easeOutQuad);
		
		this.gameObject.transform.position = new Vector3(player.transform.position.x, 0.96f, player.transform.position.z);
		
		//this.gameObject.transform.position = player.transform.position + offset;
	}
}