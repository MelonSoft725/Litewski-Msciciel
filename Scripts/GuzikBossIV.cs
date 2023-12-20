using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuzikBossIV : MonoBehaviour
{

    public BossIV boss;
    [SerializeField] GameObject player;
    [SerializeField] GameObject TPpoint;
    [SerializeField] GameObject bossfazaII;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            boss.hpBossa = 1.5f;
            player.transform.position = TPpoint.transform.position;
            bossfazaII.SetActive(true);
        }
    }
}
