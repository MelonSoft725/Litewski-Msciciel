using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonetaScript : MonoBehaviour
{
    public GameObject moneta;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            moneta.SetActive(false);
        }

    }
}
