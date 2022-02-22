using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameSO gameSO;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.8f);
        if(gameSO != null)
        {
            gameSO.OnEvent(3);
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
