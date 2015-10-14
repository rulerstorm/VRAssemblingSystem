using UnityEngine;
using System.Collections;

public class ShowResult : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cube")
        {
  
            GameObject.Find("Result").GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
