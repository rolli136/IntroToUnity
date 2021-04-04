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
    
    [SerializeField] private float _powerUpSpeed = 10f;

    [SerializeField] private SpawnManager _spawnManager;
    
    [SerializeField] private UIManager _uiManager;

    private Vector3 movement;

    private bool _powerUpActivated = false; 

    [SerializeField]
    private float _powerUpTimeout = 5f;
    

    private Vector3 playerTranslate;
    void Start()
    {
        _powerUpActivated = false; 
        transform.position = new Vector3(0f, -0.5f, 0.4f);
    }

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

       
       

       
       if (!_powerUpActivated) {
           // when PowerUp was not activated move in normal speed
           playerTranslate = new Vector3(
               1f * horizontalInput * _playerSpeed * Time.deltaTime,
               1f * jumpInput * _bouncingSpeed * Time.deltaTime,
               0f
           );
       }
       else if (_powerUpActivated)
       {
           // when Power Up is activated speed up 
           Debug.Log("It actaully should get faster");
           playerTranslate = new Vector3(
               1f * horizontalInput * _powerUpSpeed * Time.deltaTime,
               1f * jumpInput * _bouncingSpeed *_powerUpSpeed * Time.deltaTime,
               0f
           );
       }
       transform.Translate(playerTranslate);
       
    }
    
    public void RelayScore(int score)
    {
        _uiManager.AddScore(score);
    }


    public void ActivatePowerUp()
    {
        _powerUpActivated = true; 
        StartCoroutine(DeactivatePowerUp());

    }
    
    IEnumerator DeactivatePowerUp()
    {
        //PowerUp will be activated for a certain time 
        yield return new WaitForSeconds(_powerUpTimeout);
        _powerUpActivated = false;
    }

}
