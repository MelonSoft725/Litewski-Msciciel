using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossII : MonoBehaviour
{

    public GameObject Base;
    public GameObject Player;

    public GameObject Particle;

    public bool guzikClicked = false;

    public Image healthbar;

    public GameObject[] guziki;

    public GameObject canvas;

    public static bool boss2def = false;

    public GameObject[] rakietyzolte;

    public GameObject[] rakiety;
    public int RandRakieta;
    public int RandRakieta2;
    public int RandRakieta3;

    public float bossHp = 3;

    public int licznikFal = 0;

    public int wymaganeFale = 3;

    public float predkoscAtaku = 2f;

    

    private void Update()
    {
        healthbar.fillAmount = bossHp / 3;

        if (guzikClicked)
        {
            foreach (GameObject guzik in guziki)
            {
                guzik.SetActive(false);
            }

            Invoke("Attack", predkoscAtaku);

            guzikClicked = false;

        }


        if (bossHp <= 0)
        {

            Invoke("AfterBoss", 3f);
            LicznikBossow.licznikBossow++;
            boss2def = true;
            Particle.SetActive(true);
            gameObject.SetActive(false);
            //gameObject.SetActive(false);
        }


    }

    private void Start()
    {
        canvas.SetActive(true);

        foreach (GameObject rakieta in rakiety)
        {
            rakieta.SetActive(false);
        }

        foreach (GameObject rakieta in rakietyzolte)
        {
            rakieta.SetActive(false);
        }



        Invoke("Attack", predkoscAtaku);
    }

   public void Attack()
    {
        licznikFal++;

        if (licznikFal > wymaganeFale)
        {
            licznikFal = 0;

            foreach (GameObject guzik in guziki)
            {
                guzik.SetActive(true);
            }




        }
        else
        {
            RandRakieta = Random.Range(0, 48);
            RandRakieta2 = Random.Range(0, 48);
            RandRakieta3 = Random.Range(0, 48);

            foreach (GameObject rakieta in rakiety)
            {
                rakieta.SetActive(true);
            }

            rakiety[RandRakieta].SetActive(false);
            rakiety[RandRakieta2].SetActive(false);
            rakiety[RandRakieta3].SetActive(false);

            Invoke("AttackDmg", predkoscAtaku);


        }




    }

    public void AttackDmg()
    {
        foreach (GameObject rakieta in rakietyzolte)
        {

            if (rakieta == rakietyzolte[RandRakieta])
            {
                rakieta.SetActive(false);
            }
            else if (rakieta == rakietyzolte[RandRakieta2])
            {
                rakieta.SetActive(false);
            } 
            else if (rakieta == rakietyzolte[RandRakieta3])
            {
                rakieta.SetActive(false);
            }
            else
            {
                rakieta.SetActive(true);
            }



        }

        foreach (GameObject rakieta in rakiety)
        {
            rakieta.SetActive(false);
        }

        Invoke("Start", predkoscAtaku);


    }


    public void AfterBoss()
    {
        Player.transform.position = Base.transform.position;
    }


}
