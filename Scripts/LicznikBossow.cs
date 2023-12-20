using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LicznikBossow : MonoBehaviour
{

    public static int licznikBossow = 0;

    


    public TextMeshPro napis;
    void Update()
    {

        



        napis.text = licznikBossow + "/3";


    }
}
