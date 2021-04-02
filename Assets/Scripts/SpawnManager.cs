using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
   private int _counter = 0; 

   private void Start()
   {
      StartCoroutine(CoinSpawnSystem());
   }
   
   IEnumerator CoinSpawnSystem()
   {
      //Could make the Coins flickering (Leuchtend?)
      // https://www.youtube.com/watch?v=7iNSpAvNjSk&list=PLX2vGYjWbI0TiP080ELGDurOmz5NAg5CI&index=22
      //TODO beschränkte Anzahl Coins, Endlosschleife
      while (_spawningOn)
      {
         nextPositionCoinX += _spaceBetweenCoins;

         // TODO: Randomise this
         if (_counter < 6)
         {
            Instantiate(_coinPrefabs, new Vector3(nextPositionCoinX, -0.15f , 0.4f), Quaternion.Euler(90f, 0f, 0f), _coinParent.transform);
         }
         else
         {
            Instantiate(_coinPrefabs, new Vector3(nextPositionCoinX, 1f , 0.4f), Quaternion.Euler(90f, 0f, 0f), _coinParent.transform);
         }
         _counter++;

         if (_counter == 10)
         {
            _counter = 0;
         }
         yield return null;
      }
   }
   

}
