using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cantidadestrellas : MonoBehaviour
{
    private int estrellas;
    public Text cantestrellas;
    // Start is called before the first frame update
    void Start()
    {
        cantestrellas.GetComponent<Text>().text = PlayerPrefs.GetInt("estrellas", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        cantestrellas.GetComponent<Text>().text = PlayerPrefs.GetInt("estrellas", 0).ToString();
    }


  
}
