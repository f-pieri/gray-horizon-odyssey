//This is test code for my other button functions. This can be skipped if necessary
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public string sceneName; //Im declaring a string called sceneName 

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>(); //I'm getting Button component attached to this GameObject
        button.onClick.AddListener(LoadSceneOnClick); //I'm attaching listener for the button's click event
    }

    private void LoadSceneOnClick()
    {
        SceneManager.LoadScene(sceneName); //I'm loading the specified scene
    }
}

