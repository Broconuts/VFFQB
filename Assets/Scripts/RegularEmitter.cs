using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularEmitter : MonoBehaviour {

    public GameObject Flow;

    private void Awake()
    {
        GameObject flow = Instantiate(Flow);
        flow.transform.position = new Vector3(0, -20, 0);
        flow.transform.SetParent(this.transform, false);
    }
}
