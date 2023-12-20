using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossIV : MonoBehaviour
{
    public LewitujacyLaserBossIV lewitujacyLaserScript;

    [SerializeField] GameObject guzik;
    public Image healtBar;
    public float hpBossa = 3;
    public float predkoscAtaku = 3f;
    public int liczbaWylosowana;

    public GameObject[] lasery;
    public GameObject[] kwadratyOstrzegajace;

    [SerializeField] GameObject laserLewitujacy;

    void Animacja()
    {
        transform.localScale = new Vector3(
          transform.localScale.x * -1,
          transform.localScale.y,
          transform.localScale.z);

        Invoke("Animacja", 3f);
    }

    // Start is called before the first frame update
    void Start()
    {
        Animacja();
        Invoke("AtakLaserami", predkoscAtaku);
        Invoke("PrzedAtakiemLasera", predkoscAtaku / 2);
        Invoke("LaserLewitujacy", predkoscAtaku * 1);
        Invoke("ZwiekszeniePredkosciAtaku", 3f);
        Invoke("OdpalenieGuzika", predkoscAtaku * 1f);

    }

    void OdpalenieGuzika()
    {
        guzik.SetActive(true);
    }

    void ZwiekszeniePredkosciAtaku()
    {
        predkoscAtaku = 1f;
    }

    void LaserLewitujacy()
    {
       
        laserLewitujacy.SetActive(true);

        Invoke("LaserLewitujacy", 3f);
    }



    void PrzedAtakiemLasera()
    {

        liczbaWylosowana = Random.Range(0, 3);

        switch (liczbaWylosowana)
        {
            case 0:
                kwadratyOstrzegajace[0].SetActive(true);
                break;

            case 1:
                kwadratyOstrzegajace[1].SetActive(true);
                break;

            case 2:
                kwadratyOstrzegajace[2].SetActive(true);
                break;




        }


        Invoke("PrzedAtakiemLasera", predkoscAtaku);
    }

    void AtakLaserami()
    {
        

        foreach (GameObject kwadrat in kwadratyOstrzegajace)
        {
            kwadrat.SetActive(false);
        }

        switch (liczbaWylosowana)
        {
            case 0:
                Instantiate(lasery[0]);
                break;

            case 1:
                Instantiate(lasery[1]);
                break;

            case 2:
                Instantiate(lasery[2]);
                break;




        }

        Invoke("AtakLaserami", predkoscAtaku);

    }


    // Update is called once per frame
    void Update()
    {
        healtBar.fillAmount = hpBossa / 3;


    }
}
