using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*When the brick is hit, it is destroyed (it disappears off the playing field with a delay of 0.50), the score increased by 1 
     * and the number of breakable bricks on the field decreases by 1.
     */
    public void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);

        GameObject ball = GameObject.Find("ball");
        Ball ballScript = ball.GetComponent<Ball>();
        ballScript.score += 1;
        ballScript.bricksRemaining -= 1;
        print(gameObject);
    }

}
