using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button quitButton;

    private void Start()
    {
        if (playButton != null)
            playButton.onClick.AddListener(PlayGame);
        if (settingsButton != null)
            settingsButton.onClick.AddListener(OpenSettings);
        if (quitButton != null)
            quitButton.onClick.AddListener(QuitGame);
    }

    public void PlayGame()
    {
        Debug.Log("Cargando escena de juego...");
        SceneManager.LoadScene("GameScene");
    }

    public void OpenSettings()
    {
        Debug.Log("Abriendo configuración...");
        // Aquí va la lógica de settings
    }

    public void QuitGame()
    {
        Debug.Log("Saliendo del juego...");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
