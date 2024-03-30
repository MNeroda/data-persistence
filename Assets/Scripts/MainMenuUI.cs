using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject input;

    public void StartGame()
    {
        SaveManager.instance.playerName = input.GetComponent<TMP_InputField>().text;
        SceneManager.LoadScene(1);
    }
}
