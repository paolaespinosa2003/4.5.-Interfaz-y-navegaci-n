using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() { SceneManager.LoadScene("Nivel1"); }
    public void ExitGame() { Application.Quit(); }
}
