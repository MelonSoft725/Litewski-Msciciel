using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossIII : MonoBehaviour
{
    public static bool boss3def = false;

    [SerializeField] GameObject player;
    [SerializeField] GameObject home;
    [SerializeField] GameObject particle;
    [SerializeField] GameObject guzik;
    [SerializeField] GameObject canvas;

    [SerializeField] GameObject[] cienieLasery;
    [SerializeField] GameObject[] lasery;

    [SerializeField] GameObject[] rakietyCzerwone;
    [SerializeField] GameObject[] rakietyZolte;

    [SerializeField] int rand1 = 0;
    [SerializeField] int rand2 = 0;
    [SerializeField] int rand3 = 0;

    [SerializeField] int licznikFal = 0;
    public float predkoscAtaku = 3f;

    public float hp = 3;
    [SerializeField] Image healthbar;

    private void Update()
    {
        healthbar.fillAmount = hp / 3;

        if (hp <= 0)
        {
            LicznikBossow.licznikBossow++;
            boss3def = true;
            particle.SetActive(true);
            gameObject.SetActive(false);

            Invoke("TP", 3f);
            
        }

    }

    public void TP()
    {
        player.transform.position = home.transform.position;
    }


    // Start is called before the first frame update
    void Start()
    {

        // dodatkowe resetowanie wszystkich broniek bossa

        foreach (GameObject laser in lasery)
        {
            laser.SetActive(true);
        }

        foreach (GameObject lasercien in cienieLasery)
        {
            lasercien.SetActive(false);
        }

        foreach (GameObject rakiety in rakietyCzerwone)
        {
            rakiety.SetActive(false);
        }

        foreach (GameObject rakiety in rakietyZolte)
        {
            rakiety.SetActive(false);
        }

        canvas.SetActive(true);

        Invoke("AtakRakietamiCzerwonymi", predkoscAtaku);
    }

   
    public void AtakRakietamiCzerwonymi()
    {
        rand1 = Random.Range(0, 48);
        rand2 = Random.Range(0, 48);
        rand3 = Random.Range(0, 48);


        if (licznikFal < 3)
        {
            licznikFal++;

            //odpalanie czerwonych rakiet po losowaniu pol bez rakiet
            foreach (GameObject rakieta in rakietyCzerwone)
            {
                if (rakieta == rakietyCzerwone[rand1])
                {
                    rakieta.SetActive(false);
                }
                else if (rakieta == rakietyCzerwone[rand2])
                {
                    rakieta.SetActive(false);
                }
                else if (rakieta == rakietyCzerwone[rand3])
                {
                    rakieta.SetActive(false);
                }
                else
                {
                    rakieta.SetActive(true);
                }

            }




            Invoke("AtakRakietamiZoltymi", predkoscAtaku);
        }
        else
        {
            licznikFal = 0;

            Invoke("AtakLaserami", predkoscAtaku);
        }


       
    }

    public void AtakLaserami()
    {
        //odpalenie czerwonych rakiet na calej mapie
        foreach(GameObject rakiety in  rakietyCzerwone)
        {
            rakiety.SetActive(true);
        }

        Invoke("AtakLaserami2", predkoscAtaku / 2);
    }

    public void AtakLaserami2()
    {
        //wylaczenie laserow
        foreach (GameObject laser in lasery)
        {
            laser.SetActive(false);
        }
        foreach (GameObject laser in cienieLasery)
        {
            laser.SetActive(false);
        }

        Invoke("AtakLaserami3", predkoscAtaku / 2);
    }

    public void AtakLaserami3()
    {

        guzik.SetActive(true);


        //odpalenie zoltych rakiet
        foreach (GameObject rakiety in rakietyCzerwone)
        {
            rakiety.SetActive(false);
        }

        foreach (GameObject rakiety in rakietyZolte)
        {
            rakiety.SetActive(true);
        }

        Invoke("AtakLaserami4", predkoscAtaku);

    }

    public void AtakLaserami4()
    {

        //wylaczenie rakiet 
        foreach (GameObject rakiety in rakietyZolte)
        {
            rakiety.SetActive(false);
        }
        foreach (GameObject laser in cienieLasery)
        {
            laser.SetActive(true);
        }

        Invoke("AtakLaserami5", predkoscAtaku);
    }

    public void AtakLaserami5()
    {
        //odpalenie laserow ponownie
        foreach (GameObject laser in lasery)
        {
            laser.SetActive(true);
        }

        foreach (GameObject laser in cienieLasery)
        {
            laser.SetActive(false);
        }
        Invoke("AtakRakietamiCzerwonymi", predkoscAtaku);
    }



    public void AtakRakietamiZoltymi()
    {
        foreach (GameObject rakieta in rakietyZolte)
        {
            rakieta.SetActive(false);
        }



        //pdpalenie zoltych rakiet
        foreach (GameObject rakieta in rakietyZolte)
        {
            if (rakieta == rakietyZolte[rand1])
            {
                rakieta.SetActive(false);
            }
            else if (rakieta == rakietyZolte[rand2])
            {
                rakieta.SetActive(false);
            }
            else if (rakieta == rakietyZolte[rand3])
            {
                rakieta.SetActive(false);
            }
            else
            {
                rakieta.SetActive(true);
            }

        }

        Invoke("Przerwa", predkoscAtaku);

    }

    public void Przerwa()
    {

        //wylaczenie wszystkich rakiet / wyczyszczenie mapy
        foreach (GameObject rakieta in rakietyZolte)
        {
            rakieta.SetActive(false);
        }

        foreach (GameObject rakieta in rakietyCzerwone)
        {
            rakieta.SetActive(false);
        }

        Invoke("AtakRakietamiCzerwonymi", predkoscAtaku);
    }

}
