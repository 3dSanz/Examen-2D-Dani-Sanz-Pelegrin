using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.tag == "Player" && other.gameObject.layer == 7)
        {
            Destroy(this.gameObject);
        }
    }
}
