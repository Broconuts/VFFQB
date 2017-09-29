using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : MonoBehaviour {

    public VariableManager varmanager;
    public string queryVariable;
    public string queryType;

    private TypeNode node;

    void Awake()
    {
        this.queryVariable = varmanager.GenerateVariable();
    }

    public void SetType(string type)
    {
        this.queryType = type;
    }

    public string GetVariable()
    {
        return queryVariable;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision has been detected");
        if (collision.gameObject.name == "FilterPrefab(Clone)")
        {
            collision.gameObject.GetComponent<FilterNode>().SetFlowVariables(queryVariable, queryType);
            Debug.Log("Variable has been added.");
        }
        if (collision.gameObject.name == "RegularResultPrefab(Clone)") // else if fucked things up for some reason?
        {
            collision.gameObject.GetComponent<ResultNode>().setFlowVariable(queryVariable);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Collision has ended."); 
    }
}
