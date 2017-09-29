using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// used to generate the variables that flows represent
public class VariableManager : MonoBehaviour {

    private int position;

    private void Awake()
    {
        position = 0;
    }

    public string GenerateVariable()
    {
        int ascii = 97 + position;
        char character = (char)ascii;
        position++;
        Debug.Log("Variable generated");
        return character.ToString();
    }

}
