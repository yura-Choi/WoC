using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CreateNote01 : MonoBehaviour
{
	public float moveTime; //Time it will take object to move, in seconds.
	private float y_auto;

	public GameObject downPrefab;
	public GameObject upPrefab;
	public GameObject rightPrefab;
	public GameObject leftPrefab;


	private void Start()
	{

		GlobalCall.downNotes[0] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 10), Quaternion.identity);

		GlobalCall.upNotes[0] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y -18), Quaternion.identity);

		GlobalCall.rightNotes[0] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 14), Quaternion.identity);

		GlobalCall.leftNotes[0] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 12), Quaternion.identity);

	}

}