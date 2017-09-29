using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FinishQuery : MonoBehaviour
{

    private StreamWriter writer;

    public void ComposeQuery()
    {
        writer = new StreamWriter("query.txt", true);
        string[] typelines = GameObject.FindObjectOfType<TypeStore>().GetStore();
        string[] filterlines = GameObject.FindObjectOfType<FilterStore>().GetStore();
        string[] resultlines = GameObject.FindObjectOfType<ResultStore>().GetStore();

        // writing the prefixes into the query
        foreach (string line in typelines)
        {
            if (line != null)
            {
                writer.WriteLine(line);
            }
        }

        // writing the selection of results
        writer.Write("SELECT ");
        foreach (string line in resultlines)
        {
            if (line != null)
            {
                writer.Write("?" + line + " ");
            }
        }
        writer.WriteLine();

        // writing the WHERE part of the query
        writer.WriteLine("WHERE {");
        foreach (string line in filterlines)
        {
            if (line != null)
            {
                writer.WriteLine("     " + line);
            }
        }
        writer.WriteLine("}");

        writer.Close();
        Debug.Log("File created and written.");
    }

}
