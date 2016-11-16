using UnityEngine;
using System.Collections;

public class MenuCtrl : MonoBehaviour 
{
	public void LoadScene(string sceneName){
		Application.LoadLevel (sceneName);
	}

}
