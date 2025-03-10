using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Para interactuar con UI

public class ButtonSceneLoader : MonoBehaviour
{
    public string sceneToLoad; // Nombre de la escena

    // M�todo para cargar la escena
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
