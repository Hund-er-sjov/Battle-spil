using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flameTimer : MonoBehaviour
{
    public float tid = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tid -= Time.deltaTime;

        if (tid <= 0)
        {
            Destroy(gameObject);
        }
    }
}