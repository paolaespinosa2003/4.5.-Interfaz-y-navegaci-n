using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void LoadLevel1() { SceneManager.LoadScene("Nivel1"); }
    public void LoadLevel2() { SceneManager.LoadScene("Nivel2"); }
}
