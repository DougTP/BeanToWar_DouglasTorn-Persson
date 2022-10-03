using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] private float xAngle = 0;
    [SerializeField] private float yAngle = 0;
    [SerializeField] private float zAngle = 0;
    
    void Update()
    {
        // Rotates the game object on the axle decided in the unity editor
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
