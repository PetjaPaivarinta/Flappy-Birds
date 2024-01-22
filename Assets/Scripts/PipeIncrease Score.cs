using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Trigger entered");
            
            if(collision.gameObject.CompareTag("Player"))
            {
                Score.instance.UpdateScore();
                Debug.Log("Score Updated!");
            } 
        }

}
