using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example03 : MonoBehaviour
{
    public int[] Array = new int[3];
    public List<int> IntList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        Array[0] = 3;
        Array[1] = 4;
        Array[2] = 5;
        IntList.Add(3);
        IntList.Add(4);
        IntList.Add(5);
        PrintArray();
        PrintList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PrintArray()
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Debug.Log("Array: " +  Array[i]);
        }
    }
    private void PrintList()
    {
        for (int i = 0; i < IntList.Count; i++)
        {
            Debug.Log("List: " + IntList[i]);
        }
    }
}