using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    [SerializeField] private InputField playerNameInputField;
    public void EscolhaDoNomeDoJogador(InputField inputField)
    {
        TextMeshProUGUI textMeshPro = inputField.GetComponentInChildren<TextMeshProUGUI>();
        string playerName = inputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
    }

}
