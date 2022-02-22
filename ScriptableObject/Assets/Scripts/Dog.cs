using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField] private GameSO gameSO;

    private void OnEnable()
    {
        gameSO.OnEvent += Bark;
    }

    public void Bark(int hp)
    {
        Debug.Log("dog : " + hp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
