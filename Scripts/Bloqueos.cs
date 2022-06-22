using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloqueos : MonoBehaviour{
    public GameObject obstaculo1;
    public respuesta res;
    // Start is called before the first frame update
    void Start()
    {
        if(res.nivel1 == 1){
            Destroy(obstaculo1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
