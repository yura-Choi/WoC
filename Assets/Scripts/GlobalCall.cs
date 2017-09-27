using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCall : MonoBehaviour {

	// Initialize global note array
    public static GameObject[] downNotes = new GameObject[18];
    public static GameObject[] upNotes = new GameObject[21];
    public static GameObject[] rightNotes = new GameObject[17];
    public static GameObject[] leftNotes = new GameObject[16];

	// Check if player die
	public static bool isPlyerDie;

	// Gauage bar script
	public float inputTotalHp;
	public float inputCurrentHp;
	public static float TotalHp;
	public static float CurrentHp;

	public GameObject inputHealthbar;
	public static GameObject healthBar;

	void Start()
	{
		isPlyerDie = false;
		TotalHp = inputTotalHp;
		CurrentHp = inputCurrentHp;
		healthBar = inputHealthbar;
		CurrentHp = TotalHp;
	}

	public static void TakeDamage(){
		CurrentHp -= 5;
		if (CurrentHp < 0) {
			isPlyerDie = true;
			CurrentHp = 0;
		}

		healthBar.transform.localScale = new Vector3 ((CurrentHp / TotalHp), 1, 1);
	}

	public static void Heal(){
		CurrentHp += 5;
		if (CurrentHp > 150) {
			CurrentHp = 150;
		}
		healthBar.transform.localScale = new Vector3 ((CurrentHp / TotalHp), 1, 1);
	}
}
