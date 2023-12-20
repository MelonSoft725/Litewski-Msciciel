using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserLife : MonoBehaviour
{
    public GameObject me;

    private void Start()
    {
        Invoke("Destory", 2f);
    }

    private void Destory()
    {
        me.SetActive(false);
    }
}
