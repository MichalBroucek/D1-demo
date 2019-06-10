using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Move_car_player movement;

    private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        Debug.Log("Collision with: " + collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit Obstacle ...");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
