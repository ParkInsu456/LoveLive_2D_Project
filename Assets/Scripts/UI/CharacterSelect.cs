using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{    
    [SerializeField] public GameObject SelectedPrefab;
    [SerializeField] private GameObject Prefab1;    // 여기에 프리팹을 드래그앤드랍으로 캐싱한다.
    [SerializeField] private GameObject Prefab2;

    public GameObject LoginPanel;
    // 버튼에 담긴 게임오브젝트를 가져온다.
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
