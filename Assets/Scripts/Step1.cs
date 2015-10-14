using UnityEngine;
using System.Collections;

public class Step1 : MonoBehaviour {
    //float speed = 2.0f;
    GameObject cylinder;
    float aimY,aimX;
    //
    float time;
    // Use this for initialization
    void Start () {
        cylinder = GameObject.Find("Cylinder");
        aimY = cylinder.GetComponent<Transform>().position.y +2;
        aimX = cylinder.GetComponent<Transform>().position.x;
        time = 0;
    }
	
	// Update is called once per frame
	void Update () {
        float y = gameObject.transform.position.y;
        float x= gameObject.transform.position.x;
        float z = gameObject.transform.position.z;
        if (time < 5)
        {
            if (y < aimY)
            {

                transform.position += (Vector3.up * Time.deltaTime);
            }
            Debug.Log(transform.position);
            time += Time.deltaTime;
        }
        else {
            if (time < 10)
            {
                if (x > aimX)
                {
                    transform.position += (Vector3.left * Time.deltaTime);
                }
                time += Time.deltaTime;
            }
            else
            {
                transform.position += (Vector3.down * Time.deltaTime);
            }
        }
	}
   
  
}
