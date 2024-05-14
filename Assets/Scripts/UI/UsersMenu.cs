using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UsersMenu : MonoBehaviour
{

    // �����ο� UI
    // �䱸����
    // ȭ�� �����ʿ� ���� �ʿ� �ִ� ����� ����� �����ݴϴ�.


    // Users ���̾��� �̸��� ����ϴ� ���
    // ������ ���̾� ��ü�� üũ, �� �̸��� ���
    // �̰� ���� ������Ʈ?? �ؽ�Ʈ�� �Ʒ��� ������� ��������� �ϴ¹�. ī������� ī�� ������� ������ġ ����ȭ

    // üũ�� ��ü�� �̸��� ����
    // �迭�� ����
    // Text�� �迭 ���̸�ŭ ��������
    // Text�� �迭[i]�� ���



    //�迭�� �����
    public GameObject textBox;
    public GameObject List;

    public List<string> userNames;
    // ã�� ���̾� �̸�
    public string layerName = "Users";
    public string layerName2 = "Player";

    public static event Action OnUsersMenuEvent;

    

    public static void CallUsersMenuEvent()
    {
        OnUsersMenuEvent?.Invoke();
    }
    private void OnEnable()
    {
        //OnUsersMenuEvent += GetUsersName;
        //OnUsersMenuEvent += MakeUserNameList;
    }

    private void OnDisable()
    {
        OnUsersMenuEvent -= GetUsersName;
        OnUsersMenuEvent -= MakeUserNameList;
    }

    private void Start()
    {
        OnUsersMenuEvent += GetUsersName;
        OnUsersMenuEvent += MakeUserNameList;
        userNames = new List<string>();
        CallUsersMenuEvent();

        System.Delegate[] invocationList = OnUsersMenuEvent.GetInvocationList();    // �����
        foreach (System.Delegate handler in invocationList)
        {
            Debug.Log(handler.Method.Name); // �޼��� �̸� ���
        }
    }
    private void GetUsersName()
    {
        // �ش� ���̾��� ��� ���� ��ü�� ã��
        GameObject[] objs = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in objs)
        {
            if (obj.layer == LayerMask.NameToLayer(layerName) || obj.layer == LayerMask.NameToLayer(layerName2) && obj.transform.parent == null) 
            {
                PlayerInfo info = obj.GetComponent<PlayerInfo>();
                // �ش� ���̾ ���� ��ü�� �̸��� ����Ʈ�� �߰�  
                userNames.Add(info.Name);    // TODO :: �̸� �ٲ�ֱ�
            }
        }
    }

    private void MakeUserNameList()
    {
        for (int i = 0; i < userNames.Count; i++)
        {
            GameObject userNameBox = Instantiate(textBox, List.transform);
            userNameBox.GetComponentInChildren<Text>().text = userNames[i];

            float x = List.transform.position.x;
            float y = List.transform.position.y + (-20f * i);

            userNameBox.transform.position = new Vector2(x, y);
        }
    }

    // 
    // ������ȭ �ϰ� ������ƮǮ�� �ϱ�
    // �������͸� ����� ����Ʈ ������
    // �ؽ�Ʈ�� �������ִ� ������














    public void ButtonExitMenu()
    {
        gameObject.SetActive(false);
    }










}


