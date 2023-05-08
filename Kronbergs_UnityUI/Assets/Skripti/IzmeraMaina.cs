using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzmeraMaina : MonoBehaviour
{
	public float width = Screen.width; // the width of your game screen
	public float height = Screen.height; // the height of your game screen

	void Start()
	{
		float scaleX = Screen.width / width;
		float scaleY = Screen.height / height;
		Vector3 scale = new Vector3(scaleX, scaleY, 1f);

		// loop through all objects in the scene and adjust their scale
		foreach (Transform t in transform)
		{
			t.localScale = Vector3.Scale(t.localScale, scale);
		}
	}
}

