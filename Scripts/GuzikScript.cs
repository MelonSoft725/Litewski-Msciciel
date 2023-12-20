using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GuzikScript : MonoBehaviour
{

    public BossII boss;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);


            boss.wymaganeFale++;

            boss.bossHp--;

            boss.predkoscAtaku -= 0.5f;

            boss.guzikClicked = true;

        }


    }
}
