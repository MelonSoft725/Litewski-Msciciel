using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LewitujacyLaserBossIV : MonoBehaviour
{

    Vector3 poruszanieSieWLewo = new Vector3(-1f, 0f, 0f);
    Vector3 poruszanieSieWPrawo = new Vector3(1f, 0f, 0f);


    public Vector3 CzyLewo = new Vector3(-10.5f,3.5f,0f );
    public Vector3 CzyPrawo = new Vector3(10.5f, 3.5f, 0f);

    [SerializeField] bool zmieniaczStrony = false;

    // Start is called before the first frame update
    void Start()
    {
        if (zmieniaczStrony)
        {
            PoruszanieSiewPrawo();
            zmieniaczStrony = false;
        }
        else
        {
            PoruszanieSiewLewo();
            zmieniaczStrony = true;
        }
    }

    void PoruszanieSiewLewo()
    {
        

        if (gameObject.transform.position == CzyLewo)
        {
           // gameObject.SetActive(false);
            PoruszanieSiewPrawo();
        }
        else
        {
            transform.position += poruszanieSieWLewo;
            Invoke("PoruszanieSiewLewo", 0.1f);
        }


        
    }

    void PoruszanieSiewPrawo()
    {
        

        if (gameObject.transform.position == CzyPrawo)
        {
          // gameObject.SetActive(false);
            PoruszanieSiewLewo();
        }
        else
        {
            transform.position += poruszanieSieWPrawo;
            Invoke("PoruszanieSiewPrawo", 0.1f);
        }

        
    }


   
}
