using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoringCollectables : MonoBehaviour
{

    /*
     * TODO: show Scores
     * TODO: Position GoldCoins (
     */
    
    private UIManager _uiManager;
    
    private void OnTriggerEnter(Collider other) {
       

       if (other.CompareTag("Player"))
       {
           if (this.CompareTag("Coin"))
           {
               Debug.Log("This works");
               Destroy(this.gameObject);
           }
       }

       else
       {
           Debug.Log("This works aswell");
       }
       /*   // if collected Coin, add 1 Point to Scores
         if (this.CompareTag("Coin"))
         {
             _uiManager.AddScore(1);
             Destroy(this.gameObject);
         }
         
     }
     // Collecting the Gold Coins
     */
        
        
    }
}
