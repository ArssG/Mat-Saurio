using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
	[SerializeField]
	private Text percentText;

	[SerializeField]
	private Image progressImage;

	// Start is called before the first frame update
	void Start()
	{
		string nivel_a_cargar = cargarnivel.siguiente_nivel;
		StartCoroutine(LoadScene(nivel_a_cargar));
	}

	IEnumerator LoadScene(string sceneToLoad)
	{
		AsyncOperation loading = SceneManager.LoadSceneAsync(sceneToLoad);

		loading.allowSceneActivation = false;

		//Cuando la escena llega al 90% de carga, se produce el cambio de escena
		while (loading.progress < 0.9f)
		{

			//Actualizamos el % de carga de una forma optima 
			//(concatenar con + tiene un alto coste en el rendimiento)
			percentText.text = string.Format("{0}%", loading.progress * 100);

			//Actualizamos la barra de carga
			progressImage.fillAmount = loading.progress;

			//Esperamos un frame
			yield return null;
		}

		//Mostramos la carga como finalizada
		percentText.text = "100%";
		progressImage.fillAmount = 1;

		//Activamos el salto de escena.
		loading.allowSceneActivation = true;



	}
}

