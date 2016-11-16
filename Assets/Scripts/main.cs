using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {
	public bool isClicked = false;

	// Use this for initialization
	public void OnMouseDown()
	{
		isClicked = true;
		Application.LoadLevel ("gameplay_1");	
	}

}
