using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RakietyScript : MonoBehaviour
{

    

    public void AttackDmgTrans()
    {
        
        Invoke("AttackDmg", 3f);
    }



    public void AttackDmg()
    {
       
        Invoke("AfterAttack", 3f);

    }

   


}
