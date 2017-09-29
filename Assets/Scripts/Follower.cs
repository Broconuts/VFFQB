using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {

    public GameObject target;

    void Update()
    {
        if (target)
        {
            Vector3 correction = new Vector3(0, 50, 0) ;
            Vector3 targetPos = target.transform.position + correction;
            transform.position = targetPos;
        }
    }
}
