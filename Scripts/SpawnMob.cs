using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMob : MonoBehaviour
{
    [SerializeField] private GameObject Charactermob2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void update()
    {
        Instantiate(Charactermob2, transform.position, Quaternion.identity);        
    }

}
