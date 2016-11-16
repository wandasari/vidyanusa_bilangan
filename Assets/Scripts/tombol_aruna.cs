using UnityEngine;
using System.Collections;

public class tombol_aruna : MonoBehaviour {
	// Use this for initialization
		public bool isClicked = false;
		public Texture BoxTexture;      // Drag a Texture onto this item in the Inspector
		GUIContent content;
		string sceneName;

		//public string name = "oo";
		//private GUIContent someBoxContent = new GUIContent("SomeBox", "It is just a box");
		void Start()
		{
			content = new GUIContent("Dapatkah kamu membantu Aruna untuk \n merapikan dapur miliknya? Klik Main \n untuk membantunya", BoxTexture, "This is a tooltip");
		}
		
		public void OnMouseDown()
		{
			isClicked = true;
		}

	//	public void OnMouseUp()
	//	{
	//		isClicked = false;
	//	}

		public void OnGUI()
		{
			if (isClicked) {
				GUI.Box (new Rect (100, 150, 300, 90), content);
			if (GUI.Button (new Rect (210, 210, 80, 20), "MAIN")) {
				Application.LoadLevel ("gameplay_1");
			}

			//GUI.Box(new Rect(0, 0, Screen.width, Screen.height), content);
			//GUI.Label(new Rect(80,200,400,100), "Hari ini Aruna akan merapihkan dapur miliknya. Maukah kamu membantu Aruna untuk me" + this.name);
			//GUI.Label (new Rect (10, 40, 100, textureToDisplay.height), GUIContent.content);
			//	GUILayout.Box("Chat");
			//if (GUILayout.Button("Change content!")) {
			//	someBoxContent.text = "SomeSpecialBox";
			//	someBoxContent.tooltip = "Okay, this is not just a box!";
			//}
		}
	}
}
