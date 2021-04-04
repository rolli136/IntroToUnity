using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    private float _rotationsspeed = 2.5f;
 

    // TODO OnTriggerEvent = Player gets faster

   void Update() {
        // Rotation PowerUp
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * _rotationsspeed *  -90));
    }

   

    
    // when Player hits PowerUp, gets faster 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().ActivatePowerUp();
            Destroy(this.gameObject);
        }
    }
    
}
