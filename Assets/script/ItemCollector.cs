using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text PointText;

    public int strawBerries = 0;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Strawberry")) {

            Destroy(collision.gameObject);
            strawBerries ++;
            Debug.Log("StrawBerries : " + strawBerries);
            //PointText.text = "SCORE : " + strawBerries;
        }
    }
}
