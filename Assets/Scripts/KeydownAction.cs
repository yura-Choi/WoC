using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class KeydownAction : MonoBehaviour {

	public GameObject upArrow, downArrow, rightArrow, leftArrow;
	public Image scorePerfect, scoreCool, scoreGood, scoreFail;
	public Image upLight, downLight, leftLight, rightLight;

	private int upIndex, downIndex, leftIndex, rightIndex;
	GameObject[] upNotes, downNotes, rightNotes, leftNotes;
	Transform[] transUpArray, transDownArray, transRightArray, transLeftArray;


	void Start(){

		upNotes = GlobalCall.upNotes;
		downNotes = GlobalCall.downNotes;
		rightNotes = GlobalCall.rightNotes;
		leftNotes = GlobalCall.leftNotes;

		transUpArray = upNotes.Select(f => f.transform).ToArray();
		transDownArray = downNotes.Select(f => f.transform).ToArray();
		transRightArray = rightNotes.Select(f => f.transform).ToArray();
		transLeftArray = leftNotes.Select(f => f.transform).ToArray();

		// UI definition
		scorePerfect = scorePerfect.GetComponent<Image> ();
		scoreCool = scoreCool.GetComponent<Image> ();
		scoreGood = scoreGood.GetComponent<Image> ();
		scoreFail = scoreFail.GetComponent<Image> ();

		scorePerfect.CrossFadeAlpha (0, 0, true);
		scoreCool.CrossFadeAlpha (0, 0, true);
		scoreGood.CrossFadeAlpha (0, 0, true);
		scoreFail.CrossFadeAlpha (0, 0, true);

		upLight.CrossFadeAlpha (0, 0, true);
		downLight.CrossFadeAlpha (0, 0, true);
		leftLight.CrossFadeAlpha (0, 0, true);
		rightLight.CrossFadeAlpha (0, 0, true);

		upIndex = 0;
		downIndex = 0;
		leftIndex = 0;
		rightIndex = 0;
	}

	// Update is called once per frame
	void Update () {
		
		// Find crashing object when key down.
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			
			// Find around upArrow object to judge note object.
			Transform nearestNote = getClosestNote(transUpArray, upArrow, upIndex);
			getScore (nearestNote, upArrow);

			upLight.CrossFadeAlpha (30, 0.1f, true);
			upLight.CrossFadeAlpha (0, 0.1f, true);

			SpriteRenderer spRend = nearestNote.GetComponent<SpriteRenderer>();
			Color col = spRend.color;
			col.a = 0f;
			spRend.color = col;

			upIndex++;

			return;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			
			// Find around downArrow object to judge note object.
			Transform nearestNote = getClosestNote(transDownArray, downArrow, downIndex);
			getScore (nearestNote, downArrow);

			downLight.CrossFadeAlpha (30, 0.1f, true);
			downLight.CrossFadeAlpha (0, 0.1f, true);

			SpriteRenderer spRend = nearestNote.GetComponent<SpriteRenderer>();
			Color col = spRend.color;
			col.a = 0f;
			spRend.color = col;

			downIndex++;

			return;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			
			// Find around leftArrow object to judge note object.
			Transform nearestNote = getClosestNote(transLeftArray, leftArrow, leftIndex);
			getScore (nearestNote, leftArrow);

			leftLight.CrossFadeAlpha (30, 0.1f, true);
			leftLight.CrossFadeAlpha (0, 0.1f, true);

			SpriteRenderer spRend = nearestNote.GetComponent<SpriteRenderer>();
			Color col = spRend.color;
			col.a = 0f;
			spRend.color = col;

			leftIndex++;

			return;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {

			// Find around rightArrow object to judge note object.
			Transform nearestNote = getClosestNote(transRightArray, rightArrow, rightIndex);
			getScore (nearestNote, rightArrow);

			rightLight.CrossFadeAlpha (30, 0.1f, true);
			rightLight.CrossFadeAlpha (0, 0.1f, true);

			SpriteRenderer spRend = nearestNote.GetComponent<SpriteRenderer> ();
			Color col = spRend.color;
			col.a = 0f;
			spRend.color = col;

			rightIndex++;

			return;
		}
			
		//upIndex = isObjectValid (getClosestNote(transUpArray, upArrow, upIndex), upIndex);

	}

	// Find closest note object
	private Transform getClosestNote (Transform[] notes, GameObject gameObject, int index)
	{
		Transform bestTarget = null;
		float closestDistanceSqr = Mathf.Infinity;
		Vector3 currentPosition = gameObject.transform.position;
		foreach(Transform potentialTarget in notes)
		{

			for (int i = 0; i < index; i++) continue;

			Vector3 directionToTarget = potentialTarget.position - currentPosition;
			float dSqrToTarget = directionToTarget.sqrMagnitude;
			if(dSqrToTarget < closestDistanceSqr)
			{
				closestDistanceSqr = dSqrToTarget;
				bestTarget = potentialTarget;
			}
		}

		return bestTarget;
	}

	// Judgement Notes
	private void getScore (Transform target, GameObject gameObject)
	{
		float distance = Vector3.Distance (target.position, gameObject.transform.position);

		if (distance <= 0.3) {

			// Perfect
			scorePerfect.CrossFadeAlpha (30, 0.3f, true);
			scorePerfect.CrossFadeAlpha (0, 0.3f, true);

			GlobalCall.Heal ();

		} else if (distance <= 0.8) {

			// Cool
			scoreCool.CrossFadeAlpha (30, 0.3f, true);
			scoreCool.CrossFadeAlpha (0, 0.3f, true);

			GlobalCall.Heal ();

		} else if (distance <= 1.3) {

			// Good
			scoreGood.CrossFadeAlpha (30, 0.3f, true);
			scoreGood.CrossFadeAlpha (0, 0.3f, true);

			GlobalCall.Heal ();

		} else {

			// Fail
			scoreFail.CrossFadeAlpha (30, 0.3f, true);
			scoreFail.CrossFadeAlpha (0, 0.3f, true);

			GlobalCall.TakeDamage ();
		}

	}

	// If note passes through rootNote, it makes a failure decision.
	private int isObjectValid(Transform neareastObject, int index){

		float yPosition = neareastObject.position.y;


		if (yPosition > -12.91) {

			Debug.Log (yPosition);

			scoreFail.CrossFadeAlpha (30, 0.3f, true);
			scoreFail.CrossFadeAlpha (0, 0.3f, true);

			GlobalCall.TakeDamage ();
		}

		return index++;
	}

}
