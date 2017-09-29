using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Need this for calling UI scripts
using System;

public class Manager : MonoBehaviour
{
    public GameObject TypePrefab;
    public GameObject FilterPrefab;
    public GameObject RegularResultPrefab;
    public GameObject AverageResultPrefab;
    public GameObject ResultPopUp;
    public GameObject TypePopUp;
    public GameObject VariableManager;
    public Canvas canvas;
    private Text label;

    [SerializeField]
    Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it
    bool isPaused; //will be used later to differentiate between map mode and query mode

    void Start()
    {
        UIPanel.gameObject.SetActive(true); //system starts into query mode (due to lack of working map mode)
        isPaused = true; //corresponds to starting into query mode
        Instantiate(VariableManager);
        //VariableManager.transform.SetParent(this.transform, false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
            Pause();
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
            UnPause();
    }

    void Pause()
    {
        isPaused = true;
        UIPanel.gameObject.SetActive(true); //switch to query mode
        Time.timeScale = 0f; //pause the game; ???
    }

    public void UnPause()
    {
        isPaused = false;
        UIPanel.gameObject.SetActive(false); //switch to map mode
        Time.timeScale = 1f; //resume game; ???
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    public void CreateFilterNode()
    {
        GameObject filterprefab = Instantiate(FilterPrefab);
        filterprefab.transform.SetParent(UIPanel.transform, false);
    }


    // Managing the adding of result nodes
    public void PopUpResult()
    {
        if (ResultPopUp.activeSelf == false)
        {
            ResultPopUp.SetActive(true);
        }
        else
        {
            ResultPopUp.SetActive(false);
        }
    }

    public void CreateRegularResult()
    {
        ResultPopUp.SetActive(false);
        Instantiate(RegularResultPrefab);
    }

    public void CreateAverageResult()
    {
        ResultPopUp.SetActive(false);
        Instantiate(AverageResultPrefab);
    }



    // managing the adding of type nodes
    public void PopUpType()
    {
        if (TypePopUp.activeSelf == false)
        {
            TypePopUp.SetActive(true);
        }
        else
        {
            TypePopUp.SetActive(false);
        }
    }

    public void CreateTypeNodeIceFloe()
    {
        TypePopUp.SetActive(false);
        GameObject pref = Instantiate(TypePrefab);
        pref.transform.SetParent(UIPanel.transform, false);
        TypeNode type = pref.GetComponent<TypeNode>();
        type.SetType("IceFloe");
        type.WriteQueryLines();
        var txt = pref.GetComponentInChildren<TextMesh>();
        txt.text = "<b>IceFloes</b>";
        
    }

    public void CreateTypeNodeVessel()
    {
        TypePopUp.SetActive(false);
        GameObject pref = Instantiate(TypePrefab);
        pref.transform.SetParent(UIPanel.transform, false);
        TypeNode type = pref.GetComponent<TypeNode>();
        type.SetType("Vessel");
        type.WriteQueryLines();
        var txt = pref.GetComponentInChildren<TextMesh>();
        txt.text = "<b>Vessels</b>";
    }

    public void CreateTypeNodeHarbor()
    {
        TypePopUp.SetActive(false);
        GameObject pref = Instantiate(TypePrefab);
        pref.transform.SetParent(UIPanel.transform, false);
        TypeNode type = pref.GetComponent<TypeNode>();
        type.SetType("Harbor");
        type.WriteQueryLines();
        var txt = pref.GetComponentInChildren<TextMesh>();
        txt.text = "<b>Harbors</b>";
    }
}