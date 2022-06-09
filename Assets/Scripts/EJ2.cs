using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    public GameObject myObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            posicionarObjetoEnOrigen(myObj);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Debug.Log(posicionYNoNegativa(myObj));
            if(posicionYNoNegativa(myObj) == true)
            {
                Debug.Log("Y es positiva");
            }
            else
            {
                Debug.Log("Y es negativa");
            }
        }
    }

    void posicionarObjetoEnOrigen(GameObject obj)
    {
        obj.transform.position = Vector3.zero; // Vector3.zero = new Vector3(0, 0, 0)
    }

    bool posicionYNoNegativa(GameObject obj)

    {
        bool YNoNegativa = false;
        if(obj.transform.position.y >= 0)
        {
            YNoNegativa = true;
        }
        return YNoNegativa;
    }
}
