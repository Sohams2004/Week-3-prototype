using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlatform : MonoBehaviour
{
    public GameObject redWall;

    private void Start()
    {
        redWall = GameObject.FindWithTag("Red wall");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            redWall.SetActive(false);
        }
    }
}
