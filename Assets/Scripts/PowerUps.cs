using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    // Start is called before the first frame update

    private int _rotationsspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("This function does get called"); // works
        transform.Rotate(Vector3.right * _rotationsspeed * Time.deltaTime);
        
    }
}
