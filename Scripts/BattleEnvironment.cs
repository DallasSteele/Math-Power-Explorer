using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEnvironment : MonoBehaviour
{
    private List<CharacterStat> turnOrder = new List<CharacterStat>();
    private int currentTurnIndex = 0;

    public void StartBattle(){
        // initialize battle state and turn order
        // add character here for their turns
    }

    public void EndTurn(){
        currentTurnIndex = (currentTurnIndex + 1) % turnOrder.Count;
        StartTurn();
    }

    public void StartTurn(){
        // handle starting a characters turn
        CharacterStat currentCharacter = turnOrder[currentTurnIndex];
        currentCharacter.StartTurn(() => {
            //this callback is called when the characters turn is complete
        });
    }

    public void HandleCharacterAction (CharacterStat source, CharacterStat target){
        //handle actions such as attacks 
        //update stats herre
    }

    //TAMBAHANAN SISA
    

}
