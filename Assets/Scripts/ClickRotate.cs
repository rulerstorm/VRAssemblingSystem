using UnityEngine;
using System.Collections;

public class ClickRotate : MonoBehaviour {
    //test ClickRotate 123
    private bool roate; 
     private float RoatedSpeed = 1000.0F;  
     void Start () {  
        roate = false;  
     }  
       
     // Update is called once per frame  
     void Update () {  
       
         if(Input.GetMouseButton(0))  
         {  
             float y = 0;
            //Input.GetAxis("Mouse X")
            y = RoatedSpeed*Time.deltaTime;
           // && Input.GetKeyDown(KeyCode.Y)
             if (roate&&Input.GetKeyDown(KeyCode.Y))  
             {  
                 gameObject.transform.Rotate(new Vector3(0, y, 0));  
                   
            }
            if (roate && Input.GetKeyDown(KeyCode.Z))
            {
                gameObject.transform.Rotate(new Vector3(0, 0, y));

            }
            if (roate && Input.GetKeyDown(KeyCode.X))
            {
                gameObject.transform.Rotate(new Vector3(y, 0, 0));

            }

        }  
           
    }  
    void OnMouseDown()  
     {  
           
        roate =true;  
         Debug.Log("collider");
    }  
     void OnMouseUp()
    {  
         roate = false;  
         Debug.Log("Out of collider");
    }

}
