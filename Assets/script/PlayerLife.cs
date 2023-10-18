using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D Player;

    [SerializeField] public Text LifeText;

    public int Life = 2; // set Life as public for traps

    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Traps")) {
            Life--;
            if (Life < 1) {
                die();
            }
        }
        LifeText.text = "Life :" + Life;
    }

    public bool isLife() {

        if (Life < 1)
            return false;
        else
            return true;
    }

    public void die() {

        Player.bodyType = RigidbodyType2D.Static;

    }

    public void hurtByBall() {

        Life--;
        if (Life < 1) {

            die();
        }
        LifeText.text = "Life :" + Life;
    }


}
