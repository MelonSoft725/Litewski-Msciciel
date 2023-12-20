using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtakWGore : MonoBehaviour
{
    public BossIVFazaII boss;
    
    public BossIVFIIAtakLaseramiWPrawo atakwdol;
    public AtakWDol index;

    public void AtakLaserami1()
    {
        StartCoroutine(IEAtakLaserami());
    }

    IEnumerator IEAtakLaserami()
    {
        boss.cieniePoziome[index.indexupdown].SetActive(true);
        yield return new WaitForSeconds(1f);
        boss.laseryPoziome[index.indexupdown].SetActive(true);
        index.indexupdown--;
        if (index.indexupdown == 1)
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
            index.AtakLaserami1();
        }
        else
        {
            StartCoroutine(IEAtakLaserami());
        }



    }
}
