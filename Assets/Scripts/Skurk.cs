using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skurk : MonoBehaviour
{
    public Transform Spiller;  // Reference to the player's position.
    public float moveSpeed = 3f;  // Movement speed of the enemy.
    public float stoppingDistance = 0.5f;  // Distance at which the enemy stops moving (touching the player).
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Calculate the distance between the enemy and the player.
        float distance = Vector3.Distance(gameObject.transform.position, Spiller.position);

        // If the enemy is not close enough to the player, move towards the player.
        if (distance > stoppingDistance)
        {
            // Move the enemy towards the player.
            transform.position = Vector3.MoveTowards(transform.position, Spiller.position, moveSpeed * Time.deltaTime);
        }

        // Optional: make the enemy face the player as it moves
        Vector3 directionToPlayer = Spiller.position - transform.position;
        if (directionToPlayer.sqrMagnitude > 0.01f)  // Check if the direction is not zero
        {
            transform.up = directionToPlayer.normalized;  // Adjust "up" to point in the direction of the player
        }
    }
}
