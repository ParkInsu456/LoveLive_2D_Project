using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{    
    [SerializeField] public GameObject SelectedPrefab;
    [SerializeField] private GameObject Prefab1;    // ���⿡ �������� �巡�׾ص������ ĳ���Ѵ�.
    [SerializeField] private GameObject Prefab2;

    public GameObject LoginPanel;
    // ��ư�� ��� ���ӿ�����Ʈ�� �����´�.
    public void ButtonToLoadPrefab(GameObject Prefab)
    {
        SelectedPrefab = Prefab;
    }

    public void ButtonSelect1()
    {
        SelectedPrefab = Prefab1;
        Login.Instance.SelectedCharacter = SelectedPrefab;
        SwapToLoginPanel();
    }
    public void ButtonSelect2()
    {
        SelectedPrefab = Prefab2;
        Login.Instance.SelectedCharacter = SelectedPrefab;
        SwapToLoginPanel();
    }

    public void SwapToLoginPanel()
    {
        gameObject.SetActive(false);
        LoginPanel.SetActive(true);        
    }

}
