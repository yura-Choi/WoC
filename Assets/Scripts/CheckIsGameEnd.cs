using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckIsGameEnd : MonoBehaviour {

	public GameObject resultPanel;
	public GameObject score_S, score_A, score_B, score_C, score_F;
	public AudioClip effectAudio; 


	void Start(){
		resultPanel.SetActive (false);
		score_S.SetActive (false);
		score_A.SetActive (false);
		score_B.SetActive (false);
		score_C.SetActive (false);
		score_F.SetActive (false);
		
		Invoke("saveScore",GameObject.FindObjectOfType<AudioSource>().clip.length+0.3f);
		Invoke ("goTitle", GameObject.FindObjectOfType<AudioSource>().clip.length+2f);
	}

	void Update () {

		if (GlobalCall.isPlyerDie) {

			// Game Over
			Time.timeScale = 0;
			GameObject.FindObjectOfType<AudioSource>().Pause();

			saveScore ();
			goTitle ();
		}

	}

	void saveScore() {
		Scene scene = SceneManager.GetActiveScene();
		string score;

		AudioSource audio = GameObject.FindObjectOfType<AudioSource>();
		audio.clip = effectAudio;

		resultPanel.SetActive (true);
		audio.Play ();

		if (GlobalCall.CurrentHp >= 140) {
			score = "S";
			score_S.SetActive (true);
		} else if (GlobalCall.CurrentHp >= 120) {
			score = "A";
			score_A.SetActive (true);
		} else if (GlobalCall.CurrentHp >= 100) {
			score = "B";
			score_B.SetActive (true);
		} else if (GlobalCall.CurrentHp >= 80) {
			score = "C";
			score_C.SetActive (true);
		} else {
			score = "F";
			score_F.SetActive (true);
		}

		if (scene.name == "InGame01") {
			PlayerPrefs.SetString ("Stage01_score", score);

		} else if(scene.name == "InGame02"){
			PlayerPrefs.SetString ("Stage02_score", score);

		} else if (scene.name == "InGame03") {
			PlayerPrefs.SetString ("Stage03_score", score);

			Debug.Log(PlayerPrefs.GetString("Stage03_score"));
		}
	}

	void goTitle(){
		SceneManager.LoadScene("Title");
	}
}
