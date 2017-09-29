using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterStore : MonoBehaviour {

    string[] Filters;
    private int index;
    
    // Use this for initialization
	void Start () {
        Filters = new string[20];
        index = 0;
    }

    public void StoreFilter(string line)
    {
        Filters[index] = line;
        index++;
        Debug.Log("Filter stored in storage.");
    }

    public string[] GetStore()
    {
        return Filters;
    }
}
