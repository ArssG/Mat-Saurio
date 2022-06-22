using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingresar_respuesta : MonoBehaviour
{
    private string respuesta;
    public Text numero1;
    public Text numero2;
    public int random;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void ReadStringInput(string s){
        int aux1, aux2, vidas=3;
        random = Random.Range(1,10);
        while (vidas!=0){
            Debug.Log("Numero de vidas: " + vidas);
            aux1=random;
            Debug.Log("Numero aleatorio generado" + aux1);
            numero1.text = random.ToString();
            numero2.text = random.ToString();
            aux1=aux1 + aux1;
             respuesta = s;
            Debug.Log("Respuesta" + aux1);
            if (respuesta == aux1.ToString()){
                Debug.Log("Correcto");
            }
            else{
                Debug.Log("Incorrecto");
                vidas = vidas - 1;
            }
        }
      

    }
}
