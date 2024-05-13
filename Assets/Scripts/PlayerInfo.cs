using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI TxtplayerName;
    public static string Name;

 
    public void NameUpdate()
    {
        TxtplayerName.text = Name;
    }
}
