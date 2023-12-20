using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBossII : MonoBehaviour
{
    public GameObject gracz;
    public GameObject TPPoint;
    public GameObject bossII;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bossII.SetActive(true);
            
            gracz.transform.position = TPPoint.transform.position;

        }
    }
}
