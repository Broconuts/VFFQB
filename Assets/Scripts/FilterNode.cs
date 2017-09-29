using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class FilterNode : MonoBehaviour {

    public InputField inputField;
    public TextMesh text;
    public VariableManager varmanager;

    private FilterStore store;
    private string queryVariable;
    private string queryType;
    private string compareVariable;
    private string [] queryLines;

    private void Start()
    {
        queryLines = new string[2];
        store = GameObject.FindObjectOfType<FilterStore>();
    }

    public void WriteQueryLines()
    {
        store.StoreFilter(queryLines[1]);
        store.StoreFilter(queryLines[0]);
        Debug.Log("FilterNode lines have been written.");
    }

    public void SetFlowVariables(string variable, string type)
    {
        this.queryVariable = variable;
        this.queryType = type;
        Debug.Log("Variable of the FilterNode has been changed.");
    }

    void ActivateBasics()
    {
        text.gameObject.SetActive(true);
        inputField.gameObject.SetActive(true);
    }

    public void LocationFilter()
    {
        ActivateBasics();
        text.text = "Enter Location \nin question";
        // TODO: what goes in the location filter query
    }

    public void SizeFilter()
    {
        ActivateBasics();
        text.text = "Enter < | > | = size \nyou want to compare.";
        compareVariable = varmanager.GenerateVariable();
        queryLines[1] = "?" + queryVariable + " " + queryType +":size " + compareVariable + ".";
        Debug.Log("Standard Filter line created.");
    }

    public void DestinationFilter()
    {
        ActivateBasics();
        text.text = "Enter Destination or \nleave empty to see results.";
    }

    public void CaptainFilter()
    {
        ActivateBasics();
        text.text = "Enter Captain or \nleave empty to see results.";
    }

    public void getInputResult(string input)
    {
        Debug.Log("Input results received.");
        queryLines[0] = "FILTER(?" + compareVariable + " " + input + ").";
        Debug.Log("Filter Line created.");
    }

}