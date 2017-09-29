using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeStore : MonoBehaviour {

    string[] Types;
    private int index;

    // Use this for initialization
    void Start () {
        Types = new string[20];
        index = 0;
	}

    public void StoreType(string line)
    {
        Types[index] = line;
        index++;
        Debug.Log("Type stored in storage.");
    }

    public string[] GetStore()
    {
        return Types;
    }
}
