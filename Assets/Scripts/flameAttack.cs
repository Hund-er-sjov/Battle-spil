using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

public class flameAttack : MonoBehaviour
{
    public GameObject flameObj;
    public Transform spawmPosition;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(flameObj, spawmPosition.position, Quaternion.identity);
        }
    }

   
}
