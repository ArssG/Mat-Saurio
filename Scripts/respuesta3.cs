using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class respuesta3 : MonoBehaviour{
    public string entrada;
    public string nivel_reinicio;
    public GameObject inputfield;
    public GameObject TextDisplay;
    public GameObject fullvida; 
    public GameObject halfvida; 
    public GameObject lowvida; 
    public GameObject novida; 
    public Text numero1;
    public Text numero2;
    public Text cambiarnombre;
    private int random;
    private int random1;
    private int vidas = 3;
    private int i = 0;
    private int lvl =0;
    private int[] turnos;
    public int min;
    public int max;
    public int niveles;
    private int estrellas;
    Scene scene;
    public Text N_de_ejercicios;

    // Start is called before the first frame update
    void Start(){
        turnos = new int[100];
        establecer_operaciones();
        loaddata();
    
    }

    // Update is called once per frame
    void Update(){
        if(vidas == 3){
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
            //SceneManager.LoadScene(nivel_reinicio);
            cargarnivel.cargar_nivel(nivel_reinicio);
        }
        if (scene.name == "nivel9")
        {
            N_de_ejercicios.text = lvl + "/8";
        }
        else
        {
            N_de_ejercicios.text = lvl + "/10";
        }
    }

    void setrandom(){
        random = Random.Range(min,max);
        random1 = Random.Range(min,max);
    }

    int getrandom(){
        return random;
    }
    int getrandom1(){
        return random1;
    }

    /*
    public void iniciar(){
        setrandom();
        int aux = getrandom();
        int aux1 = getrandom1();
        if(aux != turnos[0] && aux != turnos[1] && aux != turnos[2] && aux != turnos[3] && aux != turnos[4] && aux != turnos[5] && aux != turnos[6] && aux != turnos[7]){
            numero1.text = aux.ToString();
            numero2.text = aux1.ToString();
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
        scene = SceneManager.GetActiveScene();
        int aux = getrandom();
        int aux1 = getrandom1();
        int aux2 = aux * aux1;
        Debug.Log("La respuesta es: " + aux2);
        entrada = inputfield.GetComponent<Text>().text;
        Debug.Log("La entrada es: " + entrada);
        if(entrada == aux2.ToString()){
            TextDisplay.GetComponent<Text>().text = "Correcto";
            Debug.Log("Correcto");
            lvl = lvl + 1;
            if(lvl == niveles){
                if (scene.name == "nivel9")
                {
                    SceneManager.LoadScene("Selectlevel");
                    if (PlayerPrefs.GetInt("nivel9", 0) != 1)
                    {
                        addestrellas();
                    }
                    PlayerPrefs.SetInt("nivel9", 1);
                }
                if (scene.name == "nivel10")
                {
                    SceneManager.LoadScene("Selectlevel");
                    if (PlayerPrefs.GetInt("nivel10", 0) != 1)
                    {
                        addestrellas();
                    }
                    PlayerPrefs.SetInt("nivel10", 1);
                }
                if (scene.name == "nivel11")
                {
                    SceneManager.LoadScene("Selectlevel");
                    if (PlayerPrefs.GetInt("nivel11", 0) != 1)
                    {
                        addestrellas();
                    }
                    PlayerPrefs.SetInt("nivel11", 1);
                }
                if (scene.name == "nivel12")
                {
                    SceneManager.LoadScene("Selectlevel");
                    if (PlayerPrefs.GetInt("nivel12", 0) != 1)
                    {
                        addestrellas();
                    }
                    PlayerPrefs.SetInt("nivel12", 1);
                }
                SceneManager.LoadScene("Selectlevel");
            }
        }
        else{
            TextDisplay.GetComponent<Text>().text = "Incorrecto";
            Debug.Log("incorrecto");
            vidas = vidas - 1;
        }
        aux2 = 0;
    }
    */
    public void establecer_operaciones()
    {
        setrandom();
        int aux = getrandom();
        int aux1 = getrandom1();
        if (aux != turnos[0] && aux != turnos[1] && aux != turnos[2] && aux != turnos[3] && aux != turnos[4] && aux != turnos[5] && aux != turnos[6] && aux != turnos[7])
        {
            numero1.text = aux.ToString();
            numero2.text = aux1.ToString();
        }
        else
        {
            establecer_operaciones();
        }
        turnos[i] = aux;
        i++;
    }
    public void operaciones(string s)
    {
        scene = SceneManager.GetActiveScene();
        int aux = getrandom();
        int aux1 = getrandom1();
        int aux2 = aux * aux1;
        Debug.Log("La respuesta es: " + aux2);
        entrada = inputfield.GetComponent<Text>().text;
        Debug.Log("La entrada es: " + entrada);
        if (entrada == aux2.ToString())
        {
            TextDisplay.GetComponent<Text>().text = "Correcto";
            Debug.Log("Correcto");
            lvl = lvl + 1;
            if (lvl == niveles)
            {
                if (scene.name == "nivel9")
                {
                    
                    if (PlayerPrefs.GetInt("nivel9", 0) != 1)
                    {
                        addestrellas();
                    }
                    PlayerPrefs.SetInt("nivel9", 1);
                    //SceneManager.LoadScene("Selectlevel");
                    cargarnivel.cargar_nivel("Selectlevel");
                }
                if (scene.name == "nivel10")
                {
                    
                    if (PlayerPrefs.GetInt("nivel10", 0) != 1)
                    {
                        addestrellas();
                    }
                    PlayerPrefs.SetInt("nivel10", 1);
                    //SceneManager.LoadScene("Selectlevel");
                    cargarnivel.cargar_nivel("Selectlevel");
                }
                if (scene.name == "nivel11")
                {
                    
                    if (PlayerPrefs.GetInt("nivel11", 0) != 1)
                    {
                        addestrellas();
                    }
                    PlayerPrefs.SetInt("nivel11", 1);
                    //SceneManager.LoadScene("Selectlevel");
                    cargarnivel.cargar_nivel("Selectlevel");
                }
                if (scene.name == "nivel12")
                {
                    
                    if (PlayerPrefs.GetInt("nivel12", 0) != 1)
                    {
                        addestrellas();
                    }
                    PlayerPrefs.SetInt("nivel12", 1);
                    //SceneManager.LoadScene("Selectlevel");
                    cargarnivel.cargar_nivel("Selectlevel");
                }
                
            }
        }
        else
        {
            TextDisplay.GetComponent<Text>().text = "Incorrecto";
            Debug.Log("incorrecto");
            vidas = vidas - 1;
        }
        aux2 = 0;
        establecer_operaciones();
    }
    private void OnDestroy()
    {
        savedata();
    }
    private void savedata()
    {
        PlayerPrefs.SetInt("estrellas", estrellas);
    }

    private void loaddata()
    {
        estrellas = PlayerPrefs.GetInt("estrellas", 0);
    }

    private void addestrellas()
    {
        estrellas = estrellas + 8;
    }

}