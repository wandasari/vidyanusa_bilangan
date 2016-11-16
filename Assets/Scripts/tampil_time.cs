using UnityEngine;
using System.Collections;

public class tampil_time : MonoBehaviour {
	public float timer =0.0f;
	public bool timerStarted = false;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.N))
			{
				if (timerStarted==false)
					timerStarted=true;
				else
					timerStarted=false;			
			}

			if(timerStarted)
			timer+=Time.deltaTime;

	}

			void onGUI()
			{
				GUI.Label(new Rect (5,5,200,100), "Timer:" +timer);
			}
}