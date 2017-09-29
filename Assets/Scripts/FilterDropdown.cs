using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class FilterDropdown : MonoBehaviour {

    public Dropdown dropdown;
    public FilterNode FilterNode;

    // Use this for initialization
    void Start () {
        PopulateList();
	}

    void PopulateList()
    {
        // TODO: fill the list depending on the input flow

        List<string> categories = new List<string>() { "Location", "Size", "Destination", "Captain" };
        dropdown.AddOptions(categories);
    }

    public void ChoiceSelection(int index)
    {
        switch (index)
        {
            case 0:
                Debug.Log("Case 0 has been activated.");
                FilterNode.LocationFilter();
                break;
            case 1:
                Debug.Log("Case 1 has been activated.");
                FilterNode.SizeFilter();
                break;
            case 2:
                Debug.Log("Case 2 has been activated.");
                FilterNode.DestinationFilter();
                break;
            case 3:
                Debug.Log("Case 3 has been activated.");
                FilterNode.CaptainFilter();
                break;
            default:
                break;
        }
    }
}
