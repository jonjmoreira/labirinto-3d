using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public GameObject portaObj;

    private void OnCollisionEnter(Collision other) {
        portaObj.transform.rotation = new Quaternion(180,180,180, 0);
        Debug.Log("Triggering");
    }
}
