using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class opendoor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mensaje;
    public string levelname;
    private bool dentro = false;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player"))
        {
            mensaje.gameObject.SetActive(true);
            dentro = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        mensaje.gameObject.SetActive(false);
            dentro = false;
    }

    private void Update() {
        if (dentro && Input.GetKey("e"))
        {
            //SceneManager.LoadScene(levelname); 
            cargarnivel.cargar_nivel(levelname);
        }
    }
}
