using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameChangeInGame : MonoBehaviour   // PlayUI - inputNameInGame¿¡ Ä³½ÌµÊ
{
    [SerializeField] private TMP_InputField inputFieldInGame;
    [SerializeField] private PlayerInfo playerInfo;

    [SerializeField] private Button enterButton;
    [SerializeField] private Image enterButtonImage;

    private void Awake()
    {
        playerInfo = GameManager.Instance.Player.GetComponent<PlayerInfo>();
    }

    private void Update()
    {
        LimitedNameLength(inputFieldInGame);
    }

    private void InputNameInGame()
    {
        playerInfo.Name = inputFieldInGame.text;
        playerInfo.NameUpdate();
    }

    public void ClickEnterButtonInGame()
    {
        InputNameInGame();

        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    void LimitedNameLength(TMP_InputField nameTxtInGame)
    {
        string curInput = nameTxtInGame.text;
        if (curInput.Length < 2 || curInput.Length > 10)
        {
            //¹öÆ° ºñÈ°¼ºÈ­
            enterButton.enabled = false;
            enterButtonImage.color = Color.gray;
        }
        else
        {
            enterButton.enabled = true;
            enterButtonImage.color = Color.white;
        }
    }
}
