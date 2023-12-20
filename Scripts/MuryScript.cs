using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuryScript : MonoBehaviour
{
    public GameObject MuryI;
    public GameObject MuryII;
    public GameObject MuryIII;



    void Update()
    {
        
        if (BossI.boss1def)
        {
            MuryI.SetActive(true);
        }

        if (BossII.boss2def)
        {
            MuryII.SetActive(true);
        }

        if (BossIII.boss3def)
        {
            MuryIII.SetActive(true);
        }
    }
}
