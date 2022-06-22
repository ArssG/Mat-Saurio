using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (PlayerPrefs.GetInt("nivel1",0) == 1 || PlayerPrefs.GetInt("nivel2", 0) == 1 || PlayerPrefs.GetInt("nivel3", 0) == 1 || PlayerPrefs.GetInt("nivel4", 0) == 1 || PlayerPrefs.GetInt("nivel5", 0) == 1 || PlayerPrefs.GetInt("nivel6", 0) == 1 || PlayerPrefs.GetInt("nivel7", 0) == 1 || PlayerPrefs.GetInt("nivel8", 0) == 1 || PlayerPrefs.GetInt("nivel9", 0) == 1 || PlayerPrefs.GetInt("nivel10", 0) == 1 || PlayerPrefs.GetInt("nivel11", 0) == 1 || PlayerPrefs.GetInt("nivel12", 0) == 1 ) {
            cargarnivel.cargar_nivel("Selectlevel");
        }
    }
    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
        cargarnivel.cargar_nivel("Selectlevel");

    }
    public void QuitGame(){
        Application.Quit();
    }
}
