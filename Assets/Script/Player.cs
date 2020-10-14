using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool Subir = false;
    public GameObject elevador;
    // Start is called before the first frame update
    void Start()
    {
        Subir = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.U)){
            Debug.Log("Você precionado U");
            if(Subir == false){
                elevador = GameObject.Find("Elevador");
                elevador.GetComponent<Animation>().GetClip("Subir");
                   Subir = true;
            }
        }
    }
}
