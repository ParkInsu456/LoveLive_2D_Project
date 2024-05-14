using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TalkArea : MonoBehaviour
{
    // ���Ǿ����� ���� �ɰ� ��ũ�������� �浹Ʈ���Ÿ� ��´�
    // ��ũ��Ʈ ĳ���� ���Ǿ����� ��.
    // 

    [SerializeField] private GameObject talkArea;
    [SerializeField] private GameObject Player;

    [SerializeField] private GameObject TalkingToUI;
    [SerializeField] private GameObject TalkUI;


    private void Awake()
    {
        
    }
    private void Update()
    {
        if (GameManager.Instance.Player != null) return;
        else if (GameManager.Instance.Player == null && Player != null)
        {
            Player = GameManager.Instance.Player;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision) // collision�� �浹�ؿ��� ���
    {
        if (collision.gameObject.layer == Player.layer)
        {

            TalkUI.SetActive(true);
        }

    }

    // ��ȭ �ý���
    // �䱸����
    // - Ʃ�Ϳ��� ������ ���� ��ȭ �ɱ� ��ư�� ����ϴ�.
    //Ʃ�Ϳ��� �־����� �ٽ� ��ư�� ������ϴ�.
    //- ��ư�� �����ٸ� ��ȭ�� ���۵˴ϴ�.

    // npc��ü�� �����
    // npc�� ������ �ʴ� ���� ������Ʈ�� �ִ�.
    // �� ������ �÷��̾� collider�� trigger�ϸ� ��ȭ�ɱ� ��ưui�� �˾��Ѵ�
    // ��ȭ�ɱ��ư�� ������ �ϴܿ� ��ȭâ�� ���. ui�� ǥ��, �۾��� ���� �����ʰ� ������ �ǳ��ֱ�. �ٸ�Ŭ������ string �����ϱ�
    // ��ȭ ui���� ��ũ��Ʈ�� ���� �����


    // 






}
