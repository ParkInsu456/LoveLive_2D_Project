using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TMP_PlayerName;
    [SerializeField] public string Name;

    //private void Awake()
    //{
    //    TMP_PlayerName = GetComponentInChildren<TextMeshProUGUI>();
    //}

    public void NameUpdate()
    {
        GameManager.Instance.Player.GetComponent<PlayerInfo>().TMP_PlayerName.text = Name;
    }
}
