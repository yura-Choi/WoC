using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingUpNote : MonoBehaviour {

    public float moveTime; //Time it will take object to move, in seconds.
    private float y_auto;
    

    // Update is called once per frame
    void Update () {

        y_auto = Time.deltaTime * moveTime;
        transform.Translate(0, y_auto, 0);
    }
}
