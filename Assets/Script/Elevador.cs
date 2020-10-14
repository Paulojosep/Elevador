using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    public GameObject elevador;
    public GameObject botaoApagado;
    public GameObject botaoAcesso;

    public bool pressionar = false;
    public bool Subir,Descer = false;
    public bool primeiro = false;


    void OnTriggerEntre(Collider other){
        if(other.tag == "Player"){
             pressionar = true;

        }
    }

    void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
             pressionar = false;

        }
    }

    // Start is called before the first frame update
   //void Start(){}

    // Update is called once per frame
    void Update()
    {
        // Boton para subir
        if(Descer == false){
            if(pressionar = true && Input.GetKey(KeyCode.Y)){
               
                elevador.GetComponent<Animator>().SetBool("subir",true);
                
                Subir = true;
                primeiro = true;

            }
        }
        // Boton para descer
        if(primeiro){
            if(Subir == false){
                if(pressionar = false && Input.GetKey(KeyCode.U)){
                    
                   elevador.GetComponent<Animator>().SetBool("subir",false);

                }
            }

        }

    }
}
