using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtakWDol : MonoBehaviour
{
    public BossIVFazaII boss;
    
    public AtakWGore atakwgore;

    public int indexupdown = 0;
    public void AtakLaserami1()
    {
        StartCoroutine(IEAtakLaserami());
    }

    IEnumerator IEAtakLaserami()
    {
        boss.cieniePoziome[indexupdown].SetActive(true);
        yield return new WaitForSeconds(1f);
        boss.laseryPoziome[indexupdown].SetActive(true);
        indexupdown++;
        if (indexupdown == 3)
        {
            yield return new WaitForSeconds(1);
            foreach (GameObject laser in boss.laseryPoziome)
            {
                laser.SetActive(false);
            }
            foreach (GameObject laser in boss.cieniePoziome)
            {
                laser.SetActive(false);
            }
            atakwgore.AtakLaserami1();



        }
        else
        {
            StartCoroutine(IEAtakLaserami());
        }



    }
}
