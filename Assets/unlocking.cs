using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlocking : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "key")
        {
            Destroy(gameObject);
        }
    }
}
