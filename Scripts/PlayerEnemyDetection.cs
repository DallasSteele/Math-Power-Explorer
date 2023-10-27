using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemyDetection : MonoBehaviour
{
    public float detectionRadius = 5f;
    private PlayerMovement playerMovement;
    private void start(){
        playerMovement = GetComponent<PlayerMovement>();
    }

    public void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Enemy")){
            Debug.Log("Player detected an enemy: " + GetComponent<Collider2D>().gameObject.name);
        
            StartBattle();
        }
    }

    private void update(){
        
    }
public void StartBattle(){
    //implement the logic to start a battle
    Debug.Log("Battle started, get ready u PPPPPpppussio!");

    playerMovement.SetCanMove(false);
    
    //add code to transition to your battle scene or initiate the battle system

}
/*public void FixedUpdate(){
    if (StartBattle = true){
        playerMovement.SetCanMove(false);
    }

}*/

//for visualizing the detection radius in the unity editor

/*
private void OnDrawGizmosSelected(){
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, detectionRadius);
}*/


}





/*
    private void update(){
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, detectionRadius);
        foreach (Collider2D collider in colliders){
            //check if the collider belongs to an enemy
            if (collider.CompareTag("Enemy")){
                Debug.Log("Player detected an enemy: " + collider.gameObject.name);
                //trigger battle or any other action (nanti combat systemnya masukin sini)
                //it is usually a transition to a battle scene, initiating a turn-based battle system, or any other battle-related action within the detection radius and triggers a battle when it detects an enemy
                StartBattle();
                break; //stop checking for more enemies once a battle is triggered
            }
        }
    }
*/
