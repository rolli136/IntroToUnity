using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] private float _playerSpeed = 5f;

    [SerializeField] private float _bouncingSpeed = 7f;

    [SerializeField] private SpawnManager _spawnManager;
    
    [SerializeField] private UIManager _uiManager;

    private Vector3 movement;
    

    private Vector3 playerTranslate;
    void Start()
    {
       
        transform.position = new Vector3(0f, -0.5f, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        // movement of the Player/ Ball 
        movement = transform.localPosition;

        float jumpInput = Input.GetAxis("Jump");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerTranslate = new Vector3(
           1f * horizontalInput * _playerSpeed * Time.deltaTime,
           1f * jumpInput * _bouncingSpeed * Time.deltaTime,
           0f
       );
       transform.Translate(playerTranslate);
    }

   /* public void RelayScore(int score)
    {
        _uiManager.AddScore(score);
    }*/
    
}
