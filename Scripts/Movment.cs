using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movment : MonoBehaviour
{

    float speed = 5f;
    public float inputx;
    public float inputy;

    public float oldx;
    public float oldy;

    public bool CanMove = true;
    public int zmienna = 0;

    //[SerializeField] private GameObject Base;
    public GameObject pressr;
    public bool canRestart = false;
   

    [SerializeField] Rigidbody2D rb;

    private Vector3 input;

    

    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.W))
        {
            

            if (zmienna == 0)
            {




                StartCoroutine(Licznik());

                
                inputy = Input.GetAxis("Vertical");

               

                if (inputy > 0)
                {
                    inputy = 1f;
                }
                else if (inputy < 0)
                {
                    inputy = -1f;
                }


                oldy = inputy;
                oldx = 0;

                input = new Vector3(0, inputy, 0);

                

                transform.position += input;
                zmienna = 1;
            }

            

        }

        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {

            if (zmienna == 0)
            {
                StartCoroutine(Licznik());

                inputx = Input.GetAxis("Horizontal");

                if (inputx > 0)
                {
                    inputx = 1f;
                }
                else if (inputx < 0)
                {
                    inputx = -1f;
                }


                oldx = inputx;
                oldy = 0;

                input = new Vector3(inputx, 0, 0);



                transform.position += input;
                zmienna = 1;

            }

            

        }

        

    }

    

  

    IEnumerator Licznik()
    {



        yield return new WaitForSecondsRealtime(0.05f);
        zmienna = 0;
        
        


    }

    public void Smierc()
    {
        gameObject.SetActive(false);
        pressr.SetActive(true);
        canRestart = true;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rakieta"))
        {
            Smierc();
        }

        if (collision.gameObject.CompareTag("Laser"))
        {
            Smierc();
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("bariera"))
        {
            input = new Vector3(-oldx, -oldy, 0);
            transform.position += input;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            //transform.position = Base.transform.position;
        }

        if (other.gameObject.CompareTag("Laser"))
        {
            Smierc();
        }


    }

    

}
