using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]public static GameManager Instance;
    [SerializeField] public GameObject Player;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }






    public void InstantiatePlayer(GameObject player)
    {
        Player = Instantiate(player);
    }
    public void InstantiatePlayer(GameObject player, Vector3 pos)
    {
        Player = Instantiate(player,pos, Quaternion.identity);
    }

}
