using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTP : MonoBehaviour
{

    [SerializeField] private GameObject gracz;
    [SerializeField] private GameObject miejsce1;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gracz.transform.position = miejsce1.transform.position;
        }
    }



}
