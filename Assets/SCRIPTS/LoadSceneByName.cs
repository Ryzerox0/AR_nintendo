using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByName : MonoBehaviour
{

    public void LoadTheScene(string nameOfScene)
    {
        SceneManager.LoadScene(nameOfScene);
    }
}
