using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private Player player;

    public static UIManager Instance;

    void Awake()
    {
        Instance = this;
    }



    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

    public void RestartGame()
    {
        player.transform.position = new Vector3(0f,88.5f,-86.5f);
        player.Hp = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);
    }

    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    }

    public void Exit()
    {
        ShowHideRestartButton(false);
        Application.Quit();
    }
}
