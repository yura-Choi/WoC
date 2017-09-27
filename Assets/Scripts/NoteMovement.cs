using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class NoteMovement : MonoBehaviour
{
	public float moveTime; //Time it will take object to move, in seconds.
	private float y_auto;

    //float theTime;

	void Update()
	{

		y_auto = Time.deltaTime * moveTime;
		transform.Translate (0, y_auto, 0);
	}
}