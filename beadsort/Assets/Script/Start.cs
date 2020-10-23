using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
	public GameObject startbuton;
	public GameObject redbutton;
	public GameObject bluebutton;
	public void tabtostart()
	{
		startbuton.SetActive(false);
		redbutton.SetActive(true);
		bluebutton.SetActive(true);

	}
}
