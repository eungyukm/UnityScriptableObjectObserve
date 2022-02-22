using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour
{
    [SerializeField] private GameSO gameSO;

    int hp;

    private void OnEnable()
    {
        gameSO.OnEvent += Hi;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Single.GetInstance().Hello();

        //Single.GetInstance().OnEvent += Hi;

    }


    public void Hi(int hp)
    {
        Debug.Log("orc hp : " + hp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
