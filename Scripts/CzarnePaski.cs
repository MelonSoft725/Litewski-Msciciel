using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CzarnePaski : MonoBehaviour
{

    [SerializeField] GameObject canvas;
    [SerializeField] GameObject canvasBossa;


    public float czas;


    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(true);

        Invoke("TurnOff", czas);


    }


    void TurnOff()
    {

        canvas.SetActive(false);
        canvasBossa.SetActive(true);

    }
}
