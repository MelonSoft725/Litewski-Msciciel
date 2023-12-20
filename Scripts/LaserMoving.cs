using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMoving : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector3 input = new Vector3 (0.2f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LicznikDoUsuniecia());
        Invoke("PrzemieszczenieLasera", 0.1f);
    }

    void PrzemieszczenieLasera()
    {
        transform.position += input;

        Invoke("PrzemieszczenieLasera", 0.01f);
    }


    IEnumerator LicznikDoUsuniecia()
    {
        yield return new WaitForSecondsRealtime(10f);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bariera"))
        {
            Destroy(gameObject);
        }
    }
}
