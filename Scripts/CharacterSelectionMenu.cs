using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionMenu : MonoBehaviour
{
    
    public GameObject[] playerObjects;
    public GameObject[] candados;
    public int selectedCharacter = 0;

    public string gameScene = "Character Selection Scene";

    private string selectedCharacterDataName = "SelectedCharacter";
    public GameObject disponible;

    void Start()
    {
        PlayerPrefs.SetInt("dino",1);
        HideAllCharacters();

        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);

        playerObjects[selectedCharacter].SetActive(true);
    }
    private void Update()
    {
        disponibilidad();
    }


    private void HideAllCharacters()
    {
        foreach (GameObject g in playerObjects)
        {
            g.SetActive(false);
        }
    }

    public void NextCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if (selectedCharacter >= playerObjects.Length)
        {
            selectedCharacter = 0;
        }
        playerObjects[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter = playerObjects.Length-1;
        }
        playerObjects[selectedCharacter].SetActive(true);
    }

    public void disponibilidad()
    {
        #region asignando valores de objetos comprados
        if (PlayerPrefs.GetInt("meteoro", 0) == 1)
        {
            PlayerPrefs.SetInt("verde_meteoro", 1);
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rosa_meteoro", 1);
            }
            if (PlayerPrefs.GetInt("color_negro", 0) == 1)
            {
                PlayerPrefs.SetInt("negro_meteoro", 1);
            }
            if (PlayerPrefs.GetInt("color_azul", 0) == 1)
            {
                PlayerPrefs.SetInt("azul_meteoro", 1);
            }
            if (PlayerPrefs.GetInt("color_cafe", 0) == 1)
            {
                PlayerPrefs.SetInt("cafe_meteoro", 1);
            }
            if (PlayerPrefs.GetInt("color_amarillo", 0) == 1)
            {
                PlayerPrefs.SetInt("amarillo_meteoro", 1);
            }
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rojo_meteoro", 1);
            }
        }
        if (PlayerPrefs.GetInt("lentes", 0) == 1)
        {
            PlayerPrefs.SetInt("verde_lentes", 1);
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rosa_lentes", 1);
            }
            if (PlayerPrefs.GetInt("color_negro", 0) == 1)
            {
                PlayerPrefs.SetInt("negro_lentes", 1);
            }
            if (PlayerPrefs.GetInt("color_azul", 0) == 1)
            {
                PlayerPrefs.SetInt("azul_lentes", 1);
            }
            if (PlayerPrefs.GetInt("color_cafe", 0) == 1)
            {
                PlayerPrefs.SetInt("cafe_lentes", 1);
            }
            if (PlayerPrefs.GetInt("color_amarillo", 0) == 1)
            {
                PlayerPrefs.SetInt("amarillo_lentes", 1);
            }
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rojo_lentes", 1);
            }
        }
        if (PlayerPrefs.GetInt("bigotes", 0) == 1)
        {
            PlayerPrefs.SetInt("verde_bigotes", 1);
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rosa_bigotes", 1);
            }
            if (PlayerPrefs.GetInt("color_negro", 0) == 1)
            {
                PlayerPrefs.SetInt("negro_bigotes", 1);
            }
            if (PlayerPrefs.GetInt("color_azul", 0) == 1)
            {
                PlayerPrefs.SetInt("azul_bigotes", 1);
            }
            if (PlayerPrefs.GetInt("color_cafe", 0) == 1)
            {
                PlayerPrefs.SetInt("cafe_bigotes", 1);
            }
            if (PlayerPrefs.GetInt("color_amarillo", 0) == 1)
            {
                PlayerPrefs.SetInt("amarillo_bigotes", 1);
            }
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rojo_bigotes", 1);
            }
        }
        if (PlayerPrefs.GetInt("cubrebocas", 0) == 1)
        {
            PlayerPrefs.SetInt("verde_cubrebocas", 1);
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rosa_cubrebocas", 1);
            }
            if (PlayerPrefs.GetInt("color_negro", 0) == 1)
            {
                PlayerPrefs.SetInt("negro_cubrebocas", 1);
            }
            if (PlayerPrefs.GetInt("color_azul", 0) == 1)
            {
                PlayerPrefs.SetInt("azul_cubrebocas", 1);
            }
            if (PlayerPrefs.GetInt("color_cafe", 0) == 1)
            {
                PlayerPrefs.SetInt("cafe_cubrebocas", 1);
            }
            if (PlayerPrefs.GetInt("color_amarillo", 0) == 1)
            {
                PlayerPrefs.SetInt("amarillo_cubrebocas", 1);
            }
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rojo_cubrebocas", 1);
            }
        }
        if (PlayerPrefs.GetInt("corona", 0) == 1)
        {
            PlayerPrefs.SetInt("verde_corona", 1);
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rosa_corona", 1);
            }
            if (PlayerPrefs.GetInt("color_negro", 0) == 1)
            {
                PlayerPrefs.SetInt("negro_corona", 1);
            }
            if (PlayerPrefs.GetInt("color_azul", 0) == 1)
            {
                PlayerPrefs.SetInt("azul_corona", 1);
            }
            if (PlayerPrefs.GetInt("color_cafe", 0) == 1)
            {
                PlayerPrefs.SetInt("cafe_corona", 1);
            }
            if (PlayerPrefs.GetInt("color_amarillo", 0) == 1)
            {
                PlayerPrefs.SetInt("amarillo_corona", 1);
            }
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rojo_corona", 1);
            }
        }
        if (PlayerPrefs.GetInt("trofeo", 0) == 1)
        {
            PlayerPrefs.SetInt("verde_trofeo", 1);
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rosa_trofeo", 1);
            }
            if (PlayerPrefs.GetInt("color_negro", 0) == 1)
            {
                PlayerPrefs.SetInt("negro_trofeo", 1);
            }
            if (PlayerPrefs.GetInt("color_azul", 0) == 1)
            {
                PlayerPrefs.SetInt("azul_trofeo", 1);
            }
            if (PlayerPrefs.GetInt("color_cafe", 0) == 1)
            {
                PlayerPrefs.SetInt("cafe_trofeo", 1);
            }
            if (PlayerPrefs.GetInt("color_amarillo", 0) == 1)
            {
                PlayerPrefs.SetInt("amarillo_trofeo", 1);
            }
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt("rojo_trofeo", 1);
            }
        }
        #endregion
        #region bloqueando/desbloqueando

        if (selectedCharacter == 0)
        {
            if (PlayerPrefs.GetInt("dino",0) == 1) {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
        }
        if (selectedCharacter == 1)
        {
            if (PlayerPrefs.GetInt("verde_meteoro", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else {
                candados[selectedCharacter].gameObject.SetActive(true);
                 }
        }
        if (selectedCharacter == 2)
        {
            if (PlayerPrefs.GetInt("verde_bigotes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 3)
        {
            if (PlayerPrefs.GetInt("verde_lentes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 4)
        {
            if (PlayerPrefs.GetInt("verde_cubrebocas", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 5)
        {
            if (PlayerPrefs.GetInt("verde_corona", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 6)
        {
            if (PlayerPrefs.GetInt("verde_trofeo", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 7)
        {
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 8)
        {
            if (PlayerPrefs.GetInt("rosa_meteoro", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 9)
        {
            if (PlayerPrefs.GetInt("rosa_bigotes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 10)
        {
            if (PlayerPrefs.GetInt("rosa_lentes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 11)
        {
            if (PlayerPrefs.GetInt("rosa_cubrebocas", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 12)
        {
            if (PlayerPrefs.GetInt("rosa_corona", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 13)
        {
            if (PlayerPrefs.GetInt("rosa_trofeo", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 14)
        {
            if (PlayerPrefs.GetInt("color_negro", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 15)
        {
            if (PlayerPrefs.GetInt("negro_meteoro", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 16)
        {
            if (PlayerPrefs.GetInt("negro_bigotes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 17)
        {
            if (PlayerPrefs.GetInt("negro_lentes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 18)
        {
            if (PlayerPrefs.GetInt("negro_cubrebocas", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 19)
        {
            if (PlayerPrefs.GetInt("negro_corona", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 20)
        {
            if (PlayerPrefs.GetInt("negro_trofeo", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 21)
        {
            if (PlayerPrefs.GetInt("color_azul", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 22)
        {
            if (PlayerPrefs.GetInt("azul_meteoro", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 23)
        {
            if (PlayerPrefs.GetInt("azul_bigotes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 24)
        {
            if (PlayerPrefs.GetInt("azul_lentes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 25)
        {
            if (PlayerPrefs.GetInt("azul_cubrebocas", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 26)
        {
            if (PlayerPrefs.GetInt("azul_corona", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 27)
        {
            if (PlayerPrefs.GetInt("azul_trofeo", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 28)
        {
            if (PlayerPrefs.GetInt("color_cafe", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 29)
        {
            if (PlayerPrefs.GetInt("cafe_meteoro", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 30)
        {
            if (PlayerPrefs.GetInt("cafe_bigotes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 31)
        {
            if (PlayerPrefs.GetInt("cafe_lentes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 32)
        {
            if (PlayerPrefs.GetInt("cafe_cubrebocas", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 33)
        {
            if (PlayerPrefs.GetInt("cafe_corona", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 34)
        {
            if (PlayerPrefs.GetInt("cafe_trofeo", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 35)
        {
            if (PlayerPrefs.GetInt("color_amarillo", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 36)
        {
            if (PlayerPrefs.GetInt("amarillo_meteoro", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 37)
        {
            if (PlayerPrefs.GetInt("amarillo_bigotes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 38)
        {
            if (PlayerPrefs.GetInt("amarillo_lentes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 39)
        {
            if (PlayerPrefs.GetInt("amarillo_cubrebocas", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 40)
        {
            if (PlayerPrefs.GetInt("amarillo_corona", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 41)
        {
            if (PlayerPrefs.GetInt("amarillo_trofeo", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 42)
        {
            if (PlayerPrefs.GetInt("color_rojo", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 43)
        {
            if (PlayerPrefs.GetInt("rojo_meteoro", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 44)
        {
            if (PlayerPrefs.GetInt("rojo_bigotes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 45)
        {
            if (PlayerPrefs.GetInt("rojo_lentes", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 46)
        {
            if (PlayerPrefs.GetInt("rojo_cubrebocas", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 47)
        {
            if (PlayerPrefs.GetInt("rojo_corona", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 48)
        {
            if (PlayerPrefs.GetInt("rojo_trofeo", 0) == 1)
            {
                candados[selectedCharacter].gameObject.SetActive(false);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        #endregion

    }

    public void StartGame()
    {
        if (selectedCharacter == 0)
        {
            if (PlayerPrefs.GetInt("dino", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
        }
        if (selectedCharacter == 1)
        {
            if (PlayerPrefs.GetInt("verde_meteoro", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {

            }
        }
        if (selectedCharacter == 2)
        {
            if (PlayerPrefs.GetInt("verde_bigotes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 3)
        {
            if (PlayerPrefs.GetInt("verde_lentes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 4)
        {
            if (PlayerPrefs.GetInt("verde_cubrebocas", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 5)
        {
            if (PlayerPrefs.GetInt("verde_corona", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 6)
        {
            if (PlayerPrefs.GetInt("verde_trofeo", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 7)
        {
            if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 8)
        {
            if (PlayerPrefs.GetInt("rosa_meteoro", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 9)
        {
            if (PlayerPrefs.GetInt("rosa_bigotes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 10)
        {
            if (PlayerPrefs.GetInt("rosa_lentes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 11)
        {
            if (PlayerPrefs.GetInt("rosa_cubrebocas", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 12)
        {
            if (PlayerPrefs.GetInt("rosa_corona", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 13)
        {
            if (PlayerPrefs.GetInt("rosa_trofeo", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 14)
        {
            if (PlayerPrefs.GetInt("color_negro", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 15)
        {
            if (PlayerPrefs.GetInt("negro_meteoro", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 16)
        {
            if (PlayerPrefs.GetInt("negro_bigotes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 17)
        {
            if (PlayerPrefs.GetInt("negro_lentes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 18)
        {
            if (PlayerPrefs.GetInt("negro_cubrebocas", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 19)
        {
            if (PlayerPrefs.GetInt("negro_corona", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 20)
        {
            if (PlayerPrefs.GetInt("negro_trofeo", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 21)
        {
            if (PlayerPrefs.GetInt("color_azul", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 22)
        {
            if (PlayerPrefs.GetInt("azul_meteoro", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 23)
        {
            if (PlayerPrefs.GetInt("azul_bigotes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 24)
        {
            if (PlayerPrefs.GetInt("azul_lentes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 25)
        {
            if (PlayerPrefs.GetInt("azul_cubrebocas", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 26)
        {
            if (PlayerPrefs.GetInt("azul_corona", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 27)
        {
            if (PlayerPrefs.GetInt("azul_trofeo", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 28)
        {
            if (PlayerPrefs.GetInt("color_cafe", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 29)
        {
            if (PlayerPrefs.GetInt("cafe_meteoro", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 30)
        {
            if (PlayerPrefs.GetInt("cafe_bigotes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 31)
        {
            if (PlayerPrefs.GetInt("cafe_lentes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 32)
        {
            if (PlayerPrefs.GetInt("cafe_cubrebocas", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 33)
        {
            if (PlayerPrefs.GetInt("cafe_corona", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 34)
        {
            if (PlayerPrefs.GetInt("cafe_trofeo", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 35)
        {
            if (PlayerPrefs.GetInt("color_amarillo", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 36)
        {
            if (PlayerPrefs.GetInt("amarillo_meteoro", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 37)
        {
            if (PlayerPrefs.GetInt("amarillo_bigotes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 38)
        {
            if (PlayerPrefs.GetInt("amarillo_lentes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 39)
        {
            if (PlayerPrefs.GetInt("amarillo_cubrebocas", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 40)
        {
            if (PlayerPrefs.GetInt("amarillo_corona", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 41)
        {
            if (PlayerPrefs.GetInt("amarillo_trofeo", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 42)
        {
            if (PlayerPrefs.GetInt("color_rojo", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 43)
        {
            if (PlayerPrefs.GetInt("rojo_meteoro", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 44)
        {
            if (PlayerPrefs.GetInt("rojo_bigotes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 45)
        {
            if (PlayerPrefs.GetInt("rojo_lentes", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 46)
        {
            if (PlayerPrefs.GetInt("rojo_cubrebocas", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 47)
        {
            if (PlayerPrefs.GetInt("rojo_corona", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
        if (selectedCharacter == 48)
        {
            if (PlayerPrefs.GetInt("rojo_trofeo", 0) == 1)
            {
                PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
                //SceneManager.LoadScene(gameScene);
                cargarnivel.cargar_nivel(gameScene);
            }
            else
            {
                candados[selectedCharacter].gameObject.SetActive(true);
            }
        }
    }

}
