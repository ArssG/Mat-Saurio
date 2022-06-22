using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compras : MonoBehaviour{
    private int estrellas;
    #region botones a borrar
    public GameObject boton;
    public GameObject boton2;
    public GameObject boton3;
    public GameObject boton4;
    public GameObject boton5;
    public GameObject boton6;
    public GameObject boton7;
    public GameObject boton8;
    public GameObject boton9;
    public GameObject boton10;
    public GameObject boton11;
    public GameObject boton12;
    #endregion
    #region candados a borrar
    public GameObject candado;
    public GameObject candado2;
    public GameObject candado3;
    public GameObject candado4;
    public GameObject candado5;
    public GameObject candado6;
    public GameObject candado7;
    public GameObject candado8;
    public GameObject candado9;
    public GameObject candado10;
    public GameObject candado11;
    public GameObject candado12;
    #endregion

    // Start is called before the first frame update
    private void Awake()
    {
        if (PlayerPrefs.GetInt("color_rosa", 0) == 1)
        {
            Destroy(boton);
            candado.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("color_negro", 0) == 1)
        {
            Destroy(boton2);
            candado2.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("color_azul", 0) == 1)
        {
            Destroy(boton3);
            candado3.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("color_cafe", 0) == 1)
        {
            Destroy(boton4);
            candado4.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("color_amarillo", 0) == 1)
        {
            Destroy(boton5);
            candado5.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("color_rojo", 0) == 1)
        {
            Destroy(boton6);
            candado6.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("meteoro", 0) == 1)
        {
            Destroy(boton7);
            candado7.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bigotes", 0) == 1)
        {
            Destroy(boton8);
            candado8.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lentes", 0) == 1)
        {
            Destroy(boton9);
            candado9.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("cubrebocas", 0) == 1)
        {
            Destroy(boton10);
            candado10.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("corona", 0) == 1)
        {
            Destroy(boton11);
            candado11.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("trofeo", 0) == 1)
        {
            Destroy(boton12);
            candado12.gameObject.SetActive(false);
        }
    }
    void Start()
    {
        loaddata();
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    public void rosa(){
        if (estrellas >= 6)
        {
            PlayerPrefs.SetInt("color_rosa", 1);
            restar_estrellas(6);
            Destroy(boton);
            candado.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void negro()
    {
        if (estrellas >= 6)
        {
            PlayerPrefs.SetInt("color_negro", 1);
            restar_estrellas(6);
            Destroy(boton2);
            candado2.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void azul()
    {
        if (estrellas >= 6)
        {
            PlayerPrefs.SetInt("color_azul", 1);
            restar_estrellas(6);
            Destroy(boton3);
            candado3.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void cafe()
    {
        if (estrellas >= 6)
        {
            PlayerPrefs.SetInt("color_cafe", 1);
            restar_estrellas(6);
            Destroy(boton4);
            candado4.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void amarillo()
    {
        if (estrellas >= 6)
        {
            PlayerPrefs.SetInt("color_amarillo", 1);
            restar_estrellas(6);
            Destroy(boton5);
            candado5.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void rojo()
    {
        if (estrellas >= 6)
        {
            PlayerPrefs.SetInt("color_rojo", 1);
            restar_estrellas(6);
            Destroy(boton6);
            candado6.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void meteoro()
    {
        if (estrellas >= 7)
        {
            PlayerPrefs.SetInt("meteoro", 1);
            restar_estrellas(7);
            Destroy(boton7);
            candado7.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void bigotes()
    {
        if (estrellas >= 7)
        {
            PlayerPrefs.SetInt("bigotes", 1);
            restar_estrellas(7);
            Destroy(boton8);
            candado8.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void lentes()
    {
        if (estrellas >= 8)
        {
            PlayerPrefs.SetInt("lentes", 1);
            restar_estrellas(8);
            Destroy(boton9);
            candado9.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void cubrebocas()
    {
        if (estrellas >= 8)
        {
            PlayerPrefs.SetInt("cubrebocas", 1);
            restar_estrellas(8);
            Destroy(boton10);
            candado10.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void corona()
    {
        if (estrellas >= 10)
        {
            PlayerPrefs.SetInt("corona", 1);
            restar_estrellas(10);
            Destroy(boton11);
            candado11.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
    }
    public void trofeo()
    {
        if (estrellas >= 14)
        {
            PlayerPrefs.SetInt("trofeo", 1);
            restar_estrellas(14);
            Destroy(boton12);
            candado12.gameObject.SetActive(false);
            savedata();
            loaddata();
        }
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
    private void restar_estrellas(int cantidad)
    {
        estrellas = estrellas - cantidad;
    }


}
