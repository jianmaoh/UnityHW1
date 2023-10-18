using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsController : MonoBehaviour
{
   
    // Start is called before the first frame update
    public float speed = 10f;

    private Rigidbody2D Traps;

    void Start()
    {

    }

    public PlayerLife playerLife;

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(0 , speed * Time.fixedDeltaTime , 0);
        //this.transform.Rotate(new Vector3(0, 0, 1), 5); 
        if (this.transform.position.y < -10.0)
        {
            this.transform.position = new Vector3(this.transform.position.x, 10.0f, this.transform.position.z);  
        }
 
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //other.gameObject.SetActive(false);
        this.transform.position = new Vector3(Random.Range(-8,8), 10.0f, this.transform.position.z);
        if (collision.gameObject.CompareTag("Player"))
        {
            playerLife.hurtByBall();
        }
    }


}


