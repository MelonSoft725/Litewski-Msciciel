using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIVFIIAtakWLewo : MonoBehaviour
{
    public BossIVFazaII boss;
    public BossIVFIIAtakLaseramiWPrawo bossAtak;

    public void AtakLaserami1()
    {
        StartCoroutine(IEAtakLaserami());
    }

    IEnumerator IEAtakLaserami()
    {
        boss.cieniePionowe[bossAtak.indexer].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        boss.laseryPionowe[bossAtak.indexer].SetActive(true);
        bossAtak.indexer--;
        if (bossAtak.indexer == 0)
        {
            yield return new WaitForSeconds(1);
            foreach (GameObject laser in boss.laseryPionowe)
            {
                laser.SetActive(false);
            }
            foreach (GameObject laser in boss.cieniePionowe)
            {
                laser.SetActive(false);
            }
            bossAtak.AtakLaserami1();
        }
        else
        {
            StartCoroutine(IEAtakLaserami());
        }



    }

}