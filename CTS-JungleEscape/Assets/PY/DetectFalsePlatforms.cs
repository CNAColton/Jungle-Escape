using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour

    
{
    bool hit;
    int FalsePlatforms = 1 << 8;
    void Update()
       
    {
        hit = Physics.Raycast(transform.position, transform.forward, 3, FalsePlatforms);
        Debug.DrawRay(transform.position , transform.forward * 3, Color.red);

        if (hit)
        {
            Debug.LogWarning("Be careful!");
        }
        else 
        {
            Debug.Log("All clear!");
        }
           
    }
}