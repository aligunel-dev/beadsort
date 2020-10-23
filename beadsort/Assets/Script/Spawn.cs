using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
	void Start()
    {
        
    }

    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene("SampleScene");
	}
}
