using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Specify the name of the scene you want to load
    public string sceneToLoad;

    // Function to be called when the button is clicked
    public void ChangeScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
