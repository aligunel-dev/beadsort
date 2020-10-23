using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCount : MonoBehaviour
{
	public string color;
	public GameObject redtext;
	public GameObject bluetext;
	public GameObject replybutton;
	int redcount=0;
	int bluecount=0;
	public GameObject particle;
	public float time = 4;
	public bool spawnbool=false;
	public GameObject Magnet;
	public void Update()
	{
		if (bluetext.GetComponent<TextMesh>().text =="%100"&& redtext.GetComponent<TextMesh>().text == "%100")
		{
			time -= Time.deltaTime;
			particle.SetActive(true);
			if (time <= 0)
			{ 
				SceneManager.LoadScene("SampleScene");
			}

		}
		if (spawnbool == true)
		{
			spawnbool = false;
			//Magnet.transform.position = new Vector3(1.443f, 0.83f, -0.089f);
			LeanTween.move(Magnet, new Vector3(0.62f, 0.83f, -1.46f), 1.0f).setEase(LeanTweenType.easeOutQuad);

		}
		
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == color)
		{
			Destroy(other.gameObject.GetComponent<FollowMagnet>());
			other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			if (color == "blue")
			{
				bluecount=bluecount+1;
				bluetext.GetComponent<TextMesh>().text = "%"+ bluecount*10;
				
			}
			if (color == "red")
			{
				redcount=redcount+1;
				redtext.GetComponent<TextMesh>().text = "%" + redcount*10;

			}
			if (bluetext.GetComponent<TextMesh>().text == "%100")
			{
				spawnbool = true;
			}
			if (redtext.GetComponent<TextMesh>().text == "%100")
			{
				spawnbool = true;

			}

		}
	}
}
