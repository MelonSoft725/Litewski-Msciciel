using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIVFazaII : MonoBehaviour
{
    public GameObject[] laseryPionowe;
    public GameObject[] cieniePionowe;

    public GameObject[] laseryPoziome;
    public GameObject[] cieniePoziome;

    public BossIVFIIAtakLaseramiWPrawo atakLaseramiWPrawo;
    public AtakWDol atakwdol;

    [SerializeField] GameObject guzik;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject laser in laseryPionowe)
        {
            laser.SetActive(false);
        }

        foreach (GameObject laser in cieniePionowe)
        {
            laser.SetActive(false);
        }

        foreach (GameObject laser in laseryPoziome)
        {
            laser.SetActive(false);
        }

        foreach (GameObject laser in cieniePoziome)
        {
            laser.SetActive(false);
        }

        atakLaseramiWPrawo.AtakLaserami1();
        atakwdol.AtakLaserami1();
        Invoke("GuzikOn", 10f);
    }

   void GuzikOn()
    {
        guzik.SetActive(true);
    }


}
