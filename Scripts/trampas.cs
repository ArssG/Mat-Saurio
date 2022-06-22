using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampas : MonoBehaviour
{
    private string selectedCharacterDataName = "SelectedCharacter";
    public int cestrellas;
    // Start is called before the first frame update
    public void colocarestrellas(){
        PlayerPrefs.SetInt("estrellas", cestrellas);
        /* PlayerPrefs.SetInt("nivel1", 0);
         PlayerPrefs.SetInt("nivel2", 0);
         PlayerPrefs.SetInt("nivel3", 0);
         PlayerPrefs.SetInt("nivel4", 0);
         PlayerPrefs.SetInt("nivel5", 0);
         PlayerPrefs.SetInt("nivel6", 0);
         PlayerPrefs.SetInt("nivel7", 0);
         PlayerPrefs.SetInt("nivel8", 0);
         PlayerPrefs.SetInt("nivel9", 0);
         PlayerPrefs.SetInt("nivel10", 0);
         PlayerPrefs.SetInt("nivel11", 0);
         PlayerPrefs.SetInt("nivel12", 0);
         PlayerPrefs.SetInt("disponible",0);
         PlayerPrefs.SetInt(selectedCharacterDataName, 0);
         PlayerPrefs.SetInt("meteoro", 0);
         PlayerPrefs.SetInt("bigotes", 0);
         PlayerPrefs.SetInt("lentes", 0);
         PlayerPrefs.SetInt("cubrebocas", 0);
         PlayerPrefs.SetInt("corona", 0);
         PlayerPrefs.SetInt("trofeo", 0);
         PlayerPrefs.SetInt("color_rosa", 0);
         PlayerPrefs.SetInt("color_negro", 0);
         PlayerPrefs.SetInt("color_azul", 0);
         PlayerPrefs.SetInt("color_cafe", 0);
         PlayerPrefs.SetInt("color_amarillo", 0);
         PlayerPrefs.SetInt("color_rojo", 0);
         PlayerPrefs.SetInt("rojo_meteoro", 0);
         PlayerPrefs.SetInt("rosa_meteoro", 0);
         PlayerPrefs.SetInt("negro_meteoro", 0);
         PlayerPrefs.SetInt("azul_meteoro", 0);
         PlayerPrefs.SetInt("cafe_meteoro", 0);
         PlayerPrefs.SetInt("amarillo_meteoro", 0);
         PlayerPrefs.SetInt("verde_meteoro", 0);
         PlayerPrefs.SetInt("rosa_lentes", 0);
         PlayerPrefs.SetInt("rojo_lentes", 0);
         PlayerPrefs.SetInt("negro_lentes", 0);
         PlayerPrefs.SetInt("azul_lentes", 0);
         PlayerPrefs.SetInt("cafe_lentes", 0);
         PlayerPrefs.SetInt("amarillo_lentes", 0);
         PlayerPrefs.SetInt("verde_lentes", 0);
         PlayerPrefs.SetInt("rosa_bigotes", 0);
         PlayerPrefs.SetInt("rojo_bigotes", 0);
         PlayerPrefs.SetInt("negro_bigotes", 0);
         PlayerPrefs.SetInt("azul_bigotes", 0);
         PlayerPrefs.SetInt("cafe_bigotes", 0);
         PlayerPrefs.SetInt("amarillo_bigotes", 0);
         PlayerPrefs.SetInt("verde_bigotes", 0);
         PlayerPrefs.SetInt("rojo_cubrebocas", 0);
         PlayerPrefs.SetInt("verde_cubrebocas", 0);
         PlayerPrefs.SetInt("rosa_cubrebocas", 0);
         PlayerPrefs.SetInt("negro_cubrebocas", 0);
         PlayerPrefs.SetInt("azul_cubrebocas", 0);
         PlayerPrefs.SetInt("cafe_cubrebocas", 0);
         PlayerPrefs.SetInt("amarillo_cubrebocas", 0);
         PlayerPrefs.SetInt("rojo_corona", 0);
         PlayerPrefs.SetInt("verde_corona", 0);
         PlayerPrefs.SetInt("rosa_corona", 0);
         PlayerPrefs.SetInt("negro_corona", 0);
         PlayerPrefs.SetInt("azul_corona", 0);
         PlayerPrefs.SetInt("cafe_corona", 0);
         PlayerPrefs.SetInt("amarillo_corona", 0);
         PlayerPrefs.SetInt("rojo_trofeo", 0);
         PlayerPrefs.SetInt("verde_trofeo", 0);
         PlayerPrefs.SetInt("rosa_trofeo", 0);
         PlayerPrefs.SetInt("negro_trofeo", 0);
         PlayerPrefs.SetInt("azul_trofeo", 0);
         PlayerPrefs.SetInt("cafe_trofeo", 0);
         PlayerPrefs.SetInt("amarillo_trofeo", 0);
        */
        PlayerPrefs.DeleteAll();



    }
}
