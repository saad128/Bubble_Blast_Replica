using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        WireController.IsFired = false;

        if (collider.tag == "Bubble")
        {
            collider.GetComponent<BubbleController>().Split();
        }
    }
}
