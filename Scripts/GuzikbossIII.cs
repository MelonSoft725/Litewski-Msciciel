using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuzikbossIII : MonoBehaviour
{


    public BossIII boss;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {

            boss.predkoscAtaku -= 0.15f;
            boss.hp--;

            gameObject.SetActive(false);
        }

    }
}
