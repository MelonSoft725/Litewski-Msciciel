using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrogScript : MonoBehaviour
{

    float speed = 5f;
    public float inputx;
    public float inputy;

    public float oldx;
    public float oldy;

    public bool CanMove = true;
    public int zmienna = 0;
    public int tura = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    [SerializeField] Rigidbody2D rb;

    private Vector3 input;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {


            if (zmienna == 0)
            {
                tura++;

                if (tura == 3)
                {

                    StartCoroutine(Licznik());

                    inputx = Random.Range(0, 2);
                    inputy = Random.Range(0, 2);

                    if (inputx > 0)
                    {
                        inputx = 1f;
                    }
                    else if (inputx <= 0)
                    {
                        inputx = -1f;
                    }

                    if (inputy > 0)
                    {
                        inputy = 1f;
                    }
                    else if (inputy <= 0)
                    {
                        inputy = -1f;
                    }

                    oldx = inputx;
                    oldy = inputy;

                    input = new Vector3(inputx, inputy, 0);



                    transform.position += input;
                    zmienna = 1;
                    tura = 0;
                }


            }



        }



    }





    IEnumerator Licznik()
    {



        yield return new WaitForSecondsRealtime(0.1f);
        zmienna = 0;




    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("bariera"))
        {
            input = new Vector3(-oldx, -oldy, 0);
            transform.position += input;
        }
    }

}
