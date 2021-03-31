using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   [SerializeField] private GameObject _coinPrefabs;

   [SerializeField] private GameObject _coinParent; 
   
   private bool _spawningOn = true;

   private float _coinPositionX = 1f;
   private float _spaceBetweenCoins = 2.5f;
   private float nextPositionCoinX = 1f;

   private void Start()
   {
      StartCoroutine(SpawnSystem());
   }
   
   IEnumerator SpawnSystem()
   {
      //Could make the Coins Rotating (flickernd)
      // https://www.youtube.com/watch?v=7iNSpAvNjSk&list=PLX2vGYjWbI0TiP080ELGDurOmz5NAg5CI&index=22
      //TODO beschränkte Anzahl Coins, Endlosschleife 
      
      while (_spawningOn)
      {
         nextPositionCoinX += _spaceBetweenCoins;
         //Instantiate(_coinPrefabs, new Vector3(nextPositionCoinX, -0.2f , 0.4f), Quaternion.identity, this.transform);
         Instantiate(_coinPrefabs, new Vector3(nextPositionCoinX, -0.2f , 0.4f), Quaternion.identity, _coinParent.transform);

         yield return null;
      }
   }
   

}
