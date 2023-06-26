using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PipeScrip : MonoBehaviour
{
    public float moveSpeed = 1;
    public double deadZone = -0.6;

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x< deadZone)
        {
            Destroy(gameObject);
        }
    }
}
