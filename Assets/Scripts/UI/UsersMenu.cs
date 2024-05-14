using System.Collections;
using System.Collections.Generic;
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

    private List<string> userNames = new List<string>();
    // ã�� ���̾� �̸�
    public string layerName = "Users";
    public string layerName2 = "Player";
    private void Start()
    {
        // �ش� ���̾��� ��� ���� ��ü�� ã��
        GameObject[] objs = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in objs)
        {
            if( obj.layer == LayerMask.NameToLayer(layerName) || obj.layer == LayerMask.NameToLayer(layerName2) && obj.transform.parent == null )
            {
                // �ش� ���̾ ���� ��ü�� �̸��� ����Ʈ�� �߰�   // ���� ������Ʈ�� �̸��� ���������ִµ� Ư���Ӽ��� �������� ��.
                userNames.Add(obj.GetComponent<PlayerInfo>().Name);
            }
        }

        MakeUserNameList();
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



















    public void ButtonExitMenu()
    {
        gameObject.SetActive(false);
    }










}


