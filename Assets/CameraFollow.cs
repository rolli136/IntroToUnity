using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  public Transform target;
  
  public Vector3 distanceToPlayer;
  
  private void LateUpdate()
  {
    // distance Camera and Player
    Vector3 desiredPosition = target.position + distanceToPlayer;
    transform.position = desiredPosition; 
    transform.LookAt(target);
  }
}
