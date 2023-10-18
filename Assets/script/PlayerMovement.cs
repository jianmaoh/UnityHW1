using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public Sprite[] sprites;
    //bool IsJump = false;
    //int JumpCount = -1;
    //int sprites_index = 0;
    private Rigidbody2D Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W)) {
            Player.velocity = new Vector3(0, 5, 0);
        }
        if (Input.GetKey(KeyCode.D) && Player.bodyType != RigidbodyType2D.Static)
        {
            //Player.velocity = new Vector3(5, 0f, 0f);
            this.transform.position += new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.A) && Player.bodyType != RigidbodyType2D.Static)
        {
            //Player.velocity = new Vector3(-5, 0f, 0f);
            this.transform.position += new Vector3(-speed * Time.fixedDeltaTime, 0f, 0f);

        }

    }
}
