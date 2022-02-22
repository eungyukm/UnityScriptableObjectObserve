using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Single : MonoBehaviour
{
    #region
    private static Single single;

    public static Single GetInstance()
    {
        if(single == null)
        {
            single = FindObjectOfType<Single>();
        }
        return single;
    }

    #endregion

    public UnityAction OnEvent;

    public void Hello()
    {
        Debug.Log("Hello!!");
    }

    private void Start()
    {
    }
}
