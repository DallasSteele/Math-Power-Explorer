using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBattle : MonoBehaviour
{
/*    private Character_Base;

    private void Awake() {
        characterBase = GetComponent<Character_Base>();
    }

    private void Start() {
        characterBase.SpawnCharacter(new Vector3(2, 0));
    }*/

    private CharacterStat characterStat;
    private void Awake(){
        characterStat = GetComponent<CharacterStat>();
    }

    public void PerformAttack(CharacterStat target){
        //the implement attack logic here, //use characterstat to access attackers stat, //target parameter to access target stat
        
        //example:
        float damage = characterStat.damage.GetValue(); //get attacker stat
        target.TakeDamage(damage); //applying damage to the target
                //access the characters stats using the characterstat field

        //access the targets stats using the target parameter
       
    }

    public void PerformSpecialAbility(CharacterStat target){
        //implement special ability logic
        //use characterstat to access characters stats
        
        //access the characters stats using the characterstat field
        bool HasSpecialAbility = characterStat.HasSpecialAbility();
        
        //example:
        if (characterStat.HasSpecialAbility()){
            //then blablalbablablalb
            //perform special abiility
            //status effects also works too
        }
    }

    //add more methods here for characters specific battle actions as needed
}
