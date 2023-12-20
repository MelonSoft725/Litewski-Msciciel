using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BossI : MonoBehaviour
{
    public static bool boss1def = false;

    int zmienna = 1;
    public int liniax = 0;
    public int liniay = 0;

    public GameObject canvas;

    public GameObject[] linieX;
    public GameObject[] linieY;
    public GameObject[] linieXCienie;
    public GameObject[] linieYCienie;

    public float hp = 3;
    public Image healthbar;

    public Animator animator;

    public GameObject particle;

    public GameObject player;
    public GameObject Base;

    void Update()
    {
        

        


        if (StartBoss.boss == true && zmienna == 1)
        {

            zmienna = 0;
            canvas.SetActive(true);
            AttackPrep();
            Invoke("Counter", 3f);

        }


        healthbar.fillAmount = hp / 3;


        if (hp <= 0)
        {
            Invoke("TPtoBase", 3f);

            particle.SetActive(true);

            LicznikBossow.licznikBossow++;
            boss1def = true;
            canvas.SetActive(false);
            gameObject.SetActive(false);
            foreach(GameObject linia in linieX)
            {
                linia.SetActive(false);
            }
            foreach (GameObject linia in linieY)
            {
                linia.SetActive(false);
            }
            foreach (GameObject linia in linieXCienie)
            {
                linia.SetActive(false);
            }
            foreach (GameObject linia in linieYCienie)
            {
                linia.SetActive(false);
            }
        }

    }

    public void TPtoBase()
    {
        player.transform.position = Base.transform.position;
    }



    public void AttackPrep()
    {
        liniax = Random.Range(1, 6);
        liniay = Random.Range(1, 6);


        linieXCienie[liniax - 1].SetActive(true);
        linieYCienie[liniay - 1].SetActive(true);


        if (boss1def == false)
        {
            Invoke("AttackPrep", 4f);

            Invoke("Attack", 1f);

            Invoke("DestroyLaser", 3f);
        }

        


    }

    public void Attack()
    {

        linieX[liniax - 1].SetActive(true);
        linieY[liniay - 1].SetActive(true);
    }

    public void DestroyLaser()
    {
        linieX[liniax - 1].SetActive(false);
        linieXCienie[liniax - 1].SetActive(false);

        linieYCienie[liniay - 1].SetActive(false);
        linieY[liniay - 1].SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && animator.speed == 0)
        {
            animator.speed = 1;
            hp -= 1;
            animator.SetTrigger("AfterAttack");

            Invoke("Counter", 10f);
        }
    }

    IEnumerator Licznik()
    {
        yield return new WaitForSeconds(3f);
        animator.speed = 0;
       
    }



    void Counter()
    {
        animator.SetTrigger("CanLand");




        
        StartCoroutine(Licznik());
    }

    

}
