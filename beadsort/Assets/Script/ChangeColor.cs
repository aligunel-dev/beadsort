using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void changeblue()
	{
		this.gameObject.GetComponent<Renderer>().sharedMaterials[1].color=Color.blue;
		variables.colorred = false;
		variables.colorblue = true;

	}
	public void changered()
	{
		this.gameObject.GetComponent<Renderer>().sharedMaterials[1].color = Color.red;
		variables.colorred = true;
		variables.colorblue = false;

	}
}
