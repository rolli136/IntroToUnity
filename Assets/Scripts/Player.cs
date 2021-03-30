using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] private float _playerSpeed = 5f;

    [SerializeField] private float _bouncingSpeed = 15f;

    private Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
       
        transform.position = new Vector3(0, 0, 0);
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

        Vector3 playerTranslate = new Vector3(
           1f * horizontalInput * _playerSpeed * Time.deltaTime,
           1f * jumpInput * _bouncingSpeed * Time.deltaTime,
           0f
       );
       transform.Translate(playerTranslate);

    }
}
