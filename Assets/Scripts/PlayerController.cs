using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed = 4f;
    public Rigidbody2D playerRb;

    private float playerMovement = 0f;


    // Update is called once per frame
    void Update()
    {
       playerMovement =  Input.GetAxis("Horizontal") * speed; 
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + Vector2.right * playerMovement * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Bubble")
        {
            Debug.Log("GAME OVER!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
