using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAgain : MonoBehaviour
{
    public void LoadStart ()
    {
        SceneManager.LoadScene("Intro");
    }
}
