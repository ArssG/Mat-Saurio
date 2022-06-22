using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class cargarnivel
{
    public static string siguiente_nivel;

    public static void cargar_nivel(string nivel)
    {
        siguiente_nivel = nivel;
        SceneManager.LoadScene("Carga");
    }

}
