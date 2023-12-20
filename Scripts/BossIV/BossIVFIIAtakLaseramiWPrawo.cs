using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIVFIIAtakLaseramiWPrawo : MonoBehaviour
{
    public BossIVFazaII boss;
    public int indexer = 0;
    public BossIVFIIAtakWLewo AtakWLewo;

    public void AtakLaserami1()
    {
        StartCoroutine(IEAtakLaserami());
    }

    IEnumerator IEAtakLaserami()
    {
        boss.cieniePionowe[indexer].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        boss.laseryPionowe[indexer].SetActive(true);
        indexer++;
        if (indexer == 4)
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

            AtakWLewo.AtakLaserami1();

        }
        else
        {
            StartCoroutine(IEAtakLaserami());
        }


        
    }

}
