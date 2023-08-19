using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example02 : MonoBehaviour
{
    public string Action = "Idle";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrintAction();
        }
    }

    void PrintAction()
    {
        switch (Action)
        {
            case "Attack":
                Debug.Log("Player Attack");
                break;
            case "Move":
                Debug.Log("Player Move");
                break;
            case "Idle":
                Debug.Log("Player Stop");
                break;

        }
    }
}
