using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0, 300);

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
    }
}
