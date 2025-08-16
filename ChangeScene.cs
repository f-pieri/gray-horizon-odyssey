using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneToLoad = "HomeMenu";

    public void MoveToHomeMenu()
    {
        //I'm loading the HomeMenu scene 
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("Scene has been switched.");

        //SceneManager.LoadScene("HomeMenu", LoadSceneMode.Additive);
        Debug.Log("HomeMenu scene loaded additively.");
    }
}
