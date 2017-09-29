using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ResultNode : MonoBehaviour {

    private string previousVariable;
    private string queryVariable;
    private ResultStore store;

    private void Start()
    {
        store = GameObject.FindObjectOfType<ResultStore>();
    }

    public void setFlowVariable(string variable)
    {
        this.queryVariable = variable;
        Debug.Log("Variable of the ResultNode has been changed.");
    }

    public void WriteQueryLines()
    {
        store.StoreResult(queryVariable);
    }
}
