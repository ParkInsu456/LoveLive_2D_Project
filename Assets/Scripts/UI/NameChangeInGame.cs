using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameChangeInGame : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameTxtInGame;
    [SerializeField] private PlayerInfo playerInfo;

    [SerializeField] private Button enterButton;
    [SerializeField] private Image enterButtonImage;

    private void Update()
    {
        LimitedNameLength(nameTxtInGame);
    }

    private void InputNameInGame()
    {
        playerInfo.Name = nameTxtInGame.text;
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
            //버튼 비활성화
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
