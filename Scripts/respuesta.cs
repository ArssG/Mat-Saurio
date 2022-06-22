using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class respuesta : MonoBehaviour{
    private string entrada;
    public GameObject TextDisplay;
    public GameObject fullvida; 
    public GameObject halfvida; 
    public GameObject lowvida; 
    public GameObject novida; 
    public Text numero1;
    public Text numero2;
    public Text cambiarnombre;
    private int random;
    private int vidas = 3;
    private int i = 0;
    private int lvl =0;
    private int[] turnos;
    public int nivel1 = 0;
    private int estrellas = 0;
    public Text N_de_ejercicios;
    // Start is called before the first frame update
    void Start(){
        turnos = new int[50];
        establecer_operaciones();
        loaddata();
    }

    // Update is called once per frame
    void Update(){
        if (vidas == 3){
            fullvida.gameObject.SetActive(true);
            halfvida.gameObject.SetActive(false);
            lowvida.gameObject.SetActive(false);
            novida.gameObject.SetActive(false);
        }
        if(vidas == 2){
            fullvida.gameObject.SetActive(false);
            halfvida.gameObject.SetActive(true);
            lowvida.gameObject.SetActive(false);
            novida.gameObject.SetActive(false);
        }
        if(vidas == 1){
            fullvida.gameObject.SetActive(false);
            halfvida.gameObject.SetActive(false);
            lowvida.gameObject.SetActive(true);
            novida.gameObject.SetActive(false);
        }
        if(vidas == 0){
            fullvida.gameObject.SetActive(false);
            halfvida.gameObject.SetActive(false);
            lowvida.gameObject.SetActive(false);
            novida.gameObject.SetActive(true);
            //SceneManager.LoadScene("nivel1");
            cargarnivel.cargar_nivel("nivel1");
        }
        N_de_ejercicios.text = lvl + "/8";

    }

    void setrandom(){
        random = Random.Range(1,10);
    }

    int getrandom(){
        return random;
    }

    /*
    public void iniciar(){
        setrandom();
        int aux = getrandom();
        if(aux != turnos[0] && aux != turnos[1] && aux != turnos[2] && aux != turnos[3] && aux != turnos[4] && aux != turnos[5] && aux != turnos[6] && aux != turnos[7]){
            numero1.text = aux.ToString();
            numero2.text = aux.ToString();
        }
        else{
            iniciar();
        }
        cambiarnombre.text = "Siguiente";
        turnos[i] = aux;
        i++;
        //Debug.Log("Los numeros de la cadena son: " + turnos[0] + turnos[1] + turnos[2] + turnos[3] + turnos[4] + turnos[5] + turnos[6]);
    }

    public void comprobar(){
        int aux = getrandom();
        int aux1 = aux + aux;
        Debug.Log("La respuesta es: " + aux1);
        entrada = inputfield.GetComponent<Text>().text;
        Debug.Log("La entrada es: " + entrada);
        if(entrada == aux1.ToString()){
            TextDisplay.GetComponent<Text>().text = "Correcto";
            Debug.Log("Correcto");
            lvl = lvl + 1;
            if(lvl == 8){
                SceneManager.LoadScene("Selectlevel");
                if (PlayerPrefs.GetInt("nivel1", 0) != 1)
                {
                    addestrellas();
                }
                PlayerPrefs.SetInt("nivel1", 1);
 

            }
        }
        else{
            TextDisplay.GetComponent<Text>().text = "Incorrecto";
            Debug.Log("incorrecto");
            vidas = vidas - 1;
        }
        aux1 = 0;
    }
    */
    public void establecer_operaciones()
    {
        setrandom();
        int aux = getrandom();
        if (aux != turnos[0] && aux != turnos[1] && aux != turnos[2] && aux != turnos[3] && aux != turnos[4] && aux != turnos[5] && aux != turnos[6] && aux != turnos[7])
        {
            numero1.text = aux.ToString();
            numero2.text = aux.ToString();
        }
        else
        {
            establecer_operaciones();
        }
        turnos[i] = aux;
        i++;
    }
    public void ReaadStringInput(string s)
    {
        entrada = s;
        Debug.Log("La entrada es: " + entrada);
        int aux = getrandom();
        int aux1 = aux + aux;
        Debug.Log("La respuesta es: " + aux1);
        Debug.Log("La entrada es: " + entrada);
        if (entrada == aux1.ToString())
        {
            TextDisplay.GetComponent<Text>().text = "Correcto";
            Debug.Log("Correcto");
            lvl = lvl + 1;
            if (lvl == 8)
            {
                if (PlayerPrefs.GetInt("nivel1", 0) != 1)
                {
                    addestrellas();
                }
                PlayerPrefs.SetInt("nivel1", 1);
                //SceneManager.LoadScene("Selectlevel");
                cargarnivel.cargar_nivel("Selectlevel");

            }
        }
        else
        {
            TextDisplay.GetComponent<Text>().text = "Incorrecto";
            Debug.Log("incorrecto");
            vidas = vidas - 1;
        }
        aux1 = 0;
        establecer_operaciones();
    }
    
    private void OnDestroy()
    {
        savedata();
    }
    private void savedata(){
        PlayerPrefs.SetInt("estrellas", estrellas);
    }

    private void loaddata()
    {
        estrellas = PlayerPrefs.GetInt("estrellas",0);
    }

    private void addestrellas(){
        estrellas = estrellas + 8;
    }

}