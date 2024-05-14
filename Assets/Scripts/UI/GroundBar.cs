using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GroundBar : MonoBehaviour
{
    [SerializeField] private GameObject login;
    [SerializeField] private GameObject inputNameInGame;
    [SerializeField] private GameObject selectCharacterMenu;
    [SerializeField] private GameObject usersPanel;

    //[SerializeField] private GameObject PlayUI;
    private SelectCharacterMenu SCMscript;

    private void Awake()
    {
        SCMscript = selectCharacterMenu.GetComponent<SelectCharacterMenu>();
    }


    public void ButtonInputNameInGame()
    {        
        inputNameInGame.SetActive(true);
        Time.timeScale = 0f;
    }


    public void ButtonSelectCharacterMenu()
    {
        selectCharacterMenu.SetActive(true);
        SCMscript.CallBoolEvent();
    }

    public void ButtonUsersMenu()
    {
        usersPanel.SetActive(true);
    }

}
