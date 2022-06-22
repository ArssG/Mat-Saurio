using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class regresar : MonoBehaviour
{
   public void back()
    {
        //SceneManager.LoadScene("Selectlevel");
        cargarnivel.cargar_nivel("Selectlevel");
    }
    public void menu(){
        //SceneManager.LoadScene("MainMenu");
        cargarnivel.cargar_nivel("MainMenu");
    }
}
