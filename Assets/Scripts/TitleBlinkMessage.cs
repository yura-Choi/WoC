using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TitleBlinkMessage : MonoBehaviour {

	Text flashingText;

	void Start () {
		flashingText = GetComponent<Text> ();
		StartCoroutine (BlinkText ());
	}

	public IEnumerator BlinkText(){
		while (true) {
			flashingText.text = "";
			yield return new WaitForSeconds (.6f);
			flashingText.text = "화면을 터치하세요";
			yield return new WaitForSeconds (.6f);
		}
	}
}
