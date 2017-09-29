using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TypeNode : MonoBehaviour {

    public GameObject TypePrefab;
    public GameObject Emitter;
    public string Type;
    private TypeStore typestore;
    private FilterStore filterstore;

    private void Awake()
    {
        GameObject emitter = Instantiate(Emitter);
        emitter.transform.position = new Vector3(0, -1, 0);
        emitter.transform.SetParent(this.transform, false);
        typestore = GameObject.FindObjectOfType<TypeStore>();
        filterstore = GameObject.FindObjectOfType<FilterStore>();
    }

    public string GetQueryType()
    {
        Debug.Log("Type returned");
        return this.Type;
    }

    public void SetType(string type)
    {
        this.Type = type;
        Debug.Log("TypeNode Type determined.");
        this.GetComponentInChildren<Flow>().SetType(Type);
    }

    public void WriteQueryLines()
    {
        var flow = this.GetComponentInChildren<Flow>();
        string variable = flow.GetVariable();

        typestore.StoreType("PREFIX " + Type + ": http://example.org/" + Type + "#/");
        filterstore.StoreFilter("?" + variable + " a " + Type + ".");
    }

}
