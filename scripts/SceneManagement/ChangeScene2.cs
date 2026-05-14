using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
{
    public void MoveToSelector()
    {
        SceneManager.LoadScene("Selector", LoadSceneMode.Single);
    }
}