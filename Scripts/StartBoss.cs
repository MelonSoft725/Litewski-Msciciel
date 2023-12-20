using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBoss : MonoBehaviour
{
    static public bool boss = false;
    public GameObject gracz;
    public GameObject TPPoint;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            StartBoss.boss = true;
            gracz.transform.position = TPPoint.transform.position;

        }
    }


}
