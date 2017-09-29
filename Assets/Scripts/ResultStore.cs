using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultStore : MonoBehaviour {

    string[] Results;
    private int index;

    // Use this for initialization
    void Start () {
        Results = new string[20];
        index = 0;
    }

    public void StoreResult(string line)
    {
        Results[index] = line;
        index++;
        Debug.Log("Result stored in storage.");
    }

    public string[] GetStore()
    {
        return Results;
    }
}
