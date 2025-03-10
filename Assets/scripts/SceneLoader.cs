using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cargar escenas

public class SceneLoader : MonoBehaviour
{
    
    public string sceneToLoad;

 
    private void OnMouseDown()
    {
      
        SceneManager.LoadScene(sceneToLoad);
    }
}
