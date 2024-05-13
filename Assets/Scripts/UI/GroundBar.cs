using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GroundBar : MonoBehaviour
{
    [SerializeField] private GameObject selectCharacterMenu;
    [SerializeField] private GameObject UsersPanel;
    //[SerializeField] private GameObject PlayUI;
    private SelectCharacterMenu SCMscript;

    private void Awake()
    {
        SCMscript = selectCharacterMenu.GetComponent<SelectCharacterMenu>();
    }

    public void ButtonSelectCharacterMenu()
    {
        selectCharacterMenu.SetActive(true);
        SCMscript.CallBoolEvent();
    }

    public void ButtonUsersMenu()
    {
        UsersPanel.SetActive(true);
    }

}
