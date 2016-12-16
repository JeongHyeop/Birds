using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    public void PlayButton()
    {
        SceneManager.LoadScene("InGameScene");
    }
    public void ExitButton()
    {
    }
    public void BackButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
