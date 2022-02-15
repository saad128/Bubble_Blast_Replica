using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    public Vector2 startForce;
    public Rigidbody2D bubbleRb;

    public GameObject nextBubble;
    // Start is called before the first frame update
    void Start()
    {
        bubbleRb.AddForce(startForce, ForceMode2D.Impulse);
    }

    public void Split()
    {
        if(nextBubble != null)
        {
            GameObject Bubble1 = Instantiate(nextBubble, bubbleRb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject Bubble2 = Instantiate(nextBubble, bubbleRb.position + Vector2.left / 4f, Quaternion.identity);

            Bubble1.GetComponent<BubbleController>().startForce = new Vector2(2f, 5f);
            Bubble2.GetComponent<BubbleController>().startForce = new Vector2(-2f, 5f);
        }
        Destroy(gameObject);
    }

   
}
