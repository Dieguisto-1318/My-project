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
        // Conectar botones a sus funciones
        if (playButton != null)
            playButton.onClick.AddListener(PlayGame);
        if (settingsButton != null)
            settingsButton.onClick.AddListener(OpenSettings);
        if (quitButton != null)
            quitButton.onClick.AddListener(QuitGame);
    }

    /// <summary>
    /// Carga la escena de juego
    /// Cambia "GameScene" por el nombre de tu escena
    /// </summary>
    public void PlayGame()
    {
        Debug.Log("🎮 Cargando escena de juego...");
        SceneManager.LoadScene("GameScene");
    }

    /// <summary>
    /// Abre el menú de configuración
    /// Expande esto con tu lógica de settings
    /// </summary>
    public void OpenSettings()
    {
        Debug.Log("⚙️ Abriendo configuración...");
        // TODO: Implementar menú de configuración
    }

    /// <summary>
    /// Sale del juego
    /// </summary>
    public void QuitGame()
    {
        Debug.Log("❌ Saliendo del juego...");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
