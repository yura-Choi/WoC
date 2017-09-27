using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CreateNote03 : MonoBehaviour
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
		GlobalCall.downNotes[1] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 20), Quaternion.identity);
		GlobalCall.downNotes[2] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 38), Quaternion.identity);
		GlobalCall.downNotes[3] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 40), Quaternion.identity);
		GlobalCall.downNotes[4] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 50), Quaternion.identity);
		GlobalCall.downNotes[5] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 62), Quaternion.identity);
		GlobalCall.downNotes[6] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 64), Quaternion.identity);
		GlobalCall.downNotes[7] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 65), Quaternion.identity);
		GlobalCall.downNotes[8] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 85), Quaternion.identity);
		GlobalCall.downNotes[9] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 99), Quaternion.identity);
		GlobalCall.downNotes[10] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 104), Quaternion.identity);
		GlobalCall.downNotes[11] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 110), Quaternion.identity);
		GlobalCall.downNotes[12] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 115), Quaternion.identity);
		GlobalCall.downNotes[13] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 131), Quaternion.identity);
		GlobalCall.downNotes[14] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 133), Quaternion.identity);
		GlobalCall.downNotes[15] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 135), Quaternion.identity);
		GlobalCall.downNotes[16] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 160), Quaternion.identity);
		GlobalCall.downNotes[17] = (GameObject)Instantiate(downPrefab, new Vector3(downPrefab.gameObject.transform.position.x, downPrefab.gameObject.transform.position.y - 165), Quaternion.identity);

		GlobalCall.upNotes[0] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y -18), Quaternion.identity);
		GlobalCall.upNotes[1] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 29), Quaternion.identity);
		GlobalCall.upNotes[2] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 37), Quaternion.identity);
		GlobalCall.upNotes[3] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 39), Quaternion.identity);
		GlobalCall.upNotes[4] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 50), Quaternion.identity);
		GlobalCall.upNotes[5] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 59), Quaternion.identity);
		GlobalCall.upNotes[6] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 60), Quaternion.identity);
		GlobalCall.upNotes[7] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 75), Quaternion.identity);
		GlobalCall.upNotes[8] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 77), Quaternion.identity);
		GlobalCall.upNotes[9] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 99), Quaternion.identity);
		GlobalCall.upNotes[10] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 104), Quaternion.identity);
		GlobalCall.upNotes[11] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 110), Quaternion.identity);
		GlobalCall.upNotes[12] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 115), Quaternion.identity);
		GlobalCall.upNotes[13] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 125), Quaternion.identity);
		GlobalCall.upNotes[14] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 140), Quaternion.identity);
		GlobalCall.upNotes[15] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 142), Quaternion.identity);
		GlobalCall.upNotes[16] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 150), Quaternion.identity);
		GlobalCall.upNotes[17] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 154), Quaternion.identity);
		GlobalCall.upNotes[18] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 158), Quaternion.identity);
		GlobalCall.upNotes[19] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 176), Quaternion.identity);
		GlobalCall.upNotes[20] = (GameObject)Instantiate(upPrefab, new Vector3(upPrefab.gameObject.transform.position.x, upPrefab.gameObject.transform.position.y - 182), Quaternion.identity);

		GlobalCall.rightNotes[0] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 14), Quaternion.identity);
		GlobalCall.rightNotes[1] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 24), Quaternion.identity);
		GlobalCall.rightNotes[2] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 31), Quaternion.identity);
		GlobalCall.rightNotes[3] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 33), Quaternion.identity);
		GlobalCall.rightNotes[4] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 42), Quaternion.identity);
		GlobalCall.rightNotes[5] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 44), Quaternion.identity);
		GlobalCall.rightNotes[6] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 57), Quaternion.identity);
		GlobalCall.rightNotes[7] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y -75), Quaternion.identity);
		GlobalCall.rightNotes[8] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 88), Quaternion.identity);
		GlobalCall.rightNotes[9] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 93), Quaternion.identity);
		GlobalCall.rightNotes[10] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 123), Quaternion.identity);
		GlobalCall.rightNotes[11] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 142), Quaternion.identity);
		GlobalCall.rightNotes[12] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 173), Quaternion.identity);
		GlobalCall.rightNotes[13] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 179), Quaternion.identity);
		GlobalCall.rightNotes[14] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 186), Quaternion.identity);
		GlobalCall.rightNotes[15] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 198), Quaternion.identity);
		GlobalCall.rightNotes[16] = (GameObject)Instantiate(rightPrefab, new Vector3(rightPrefab.gameObject.transform.position.x, rightPrefab.gameObject.transform.position.y - 250), Quaternion.identity);

		GlobalCall.leftNotes[0] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 12), Quaternion.identity);
		GlobalCall.leftNotes[1] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 22), Quaternion.identity);
		GlobalCall.leftNotes[2] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 32), Quaternion.identity);
		GlobalCall.leftNotes[3] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 34), Quaternion.identity);
		GlobalCall.leftNotes[4] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 42), Quaternion.identity);
		GlobalCall.leftNotes[5] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 44), Quaternion.identity);
		GlobalCall.leftNotes[6] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 55), Quaternion.identity);
		GlobalCall.leftNotes[7] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 70), Quaternion.identity);
		GlobalCall.leftNotes[8] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 89), Quaternion.identity);
		GlobalCall.leftNotes[9] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 93), Quaternion.identity);
		GlobalCall.leftNotes[10] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 121), Quaternion.identity);
		GlobalCall.leftNotes[11] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 165), Quaternion.identity);
		GlobalCall.leftNotes[12] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 188), Quaternion.identity);
		GlobalCall.leftNotes[13] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 196), Quaternion.identity);
		GlobalCall.leftNotes[14] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 250), Quaternion.identity);
		GlobalCall.leftNotes[15] = (GameObject)Instantiate(leftPrefab, new Vector3(leftPrefab.gameObject.transform.position.x, leftPrefab.gameObject.transform.position.y - 250), Quaternion.identity);
        
    }

}