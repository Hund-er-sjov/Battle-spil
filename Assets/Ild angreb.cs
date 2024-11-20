using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ildangreb : MonoBehaviour
{
    

    public GameObject angreb;
    public Transform target;
    private float cooldownTimer = 5f;
    private float startCooldownTimer = 5f;

    public float bulletDestroyTime = 5f;

    private void Start()
    {
       
        
        startCooldownTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownTimer > 0)
        {
            Destroy(angreb);
        }

        
        
        cooldownTimer -= Time.deltaTime;


        print (cooldownTimer);
        
        if (Input.GetMouseButtonDown(0) && cooldownTimer < 0)
        {
            GameObject angrebPrefab = Instantiate(angreb, target.transform.position, target.transform.rotation);
            cooldownTimer = startCooldownTimer;
            //angrebPrefab.transform.SetParent(transform);
            Destroy(angrebPrefab, bulletDestroyTime);
        }
       
    }
    
}
