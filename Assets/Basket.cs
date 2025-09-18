using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter"); // finds GameObject named "ScoreCounter"
        scoreCounter = scoreGO.GetComponent<ScoreCounter>(); // get ScoreCounter Script component of scoreGO
    }

    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition; // Get current screen position of mouse
        mousePos2D.z = -Camera.main.transform.position.z; // Camera's z sets how far the mouse is pushed into 3D, set Main Camera tag to MainCamera if there's issues
        
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); // Convert the point from 2D screen space into 3D game world space
        // Move x position of Basket to x position of mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision coll) {
        // Find out what hit the basket, destroy it if Apple
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.CompareTag("Apple")) {
            Destroy(collidedWith);
            scoreCounter.score += 100; // Increase score by 100 per apple collided with
            HighScore.TRY_SET_HIGH_SCORE(scoreCounter.score);
        }
    }
}
