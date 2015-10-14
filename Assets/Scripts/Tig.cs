using UnityEngine;
using System.Collections;

public class Tig : MonoBehaviour {

    // Use this for initialization
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cube")
        {
            other.gameObject.GetComponent<Step1>().enabled = false;
            GameObject.Find("Result").GetComponent<MeshRenderer>().enabled=true;
           
        }
    }
}
