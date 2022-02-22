using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "SO/GameSO", fileName ="File SO")]
public class GameSO : ScriptableObject
{
    public int hp;

    public UnityAction<int> OnEvent;

    private void OnEnable()
    {
        if(OnEvent != null)
        {
            OnEvent.Invoke(hp);
        }
        else
        {
            Debug.Log("등록 안됨");
        }
    }
}
