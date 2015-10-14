using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Mouse : MonoBehaviour {

    public Text detailText;

    Vector3 cameraOffset = new Vector3(-5f, 2.5f, 0);
	//test update多舒服啊
	// Update is called once per frame
	void Update () {
  /*      if (Input.GetMouseButtonDown(0))
        {
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            

            RaycastHit hit;
            if (Physics.Raycast(camRay, out hit, 999, 1))   //999是最大距离，1表示default层
            {
                if (hit.collider.gameObject.tag == "Cube")   //gameObject在collider里面
                {
                    detailText.text = "URI=file:" + Application.dataPath + "/testDatabase.db"; ;

                    cameraOffset = new Vector3(-5f, 2.5f, -6);

                    string text = SQLiteHelper.queryWithTableName("Cube");
                    detailText.text = text;

                }
                else if (hit.collider.gameObject.tag == "Cylinder")
                {
                    //Debug.Log("sdsdfsf");

                    cameraOffset = new Vector3(-5f, 2.5f, 6);

                    string text = SQLiteHelper.queryWithTableName("Cylinder");
                    detailText.text = text;

                    
                }
            }else
            {
                cameraOffset = new Vector3(-5f, 2.5f, 0);
                detailText.text = null;
            }
        }*/
	
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(180, 400, 60, 30), "退出"))
        {
            Application.Quit();
        }
        if(GUI.Button(new Rect(300,400,60,30),"开始动画演示"))
        {
            Application.LoadLevel("Animation");
        }
    }


    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, cameraOffset, 3f * Time.deltaTime);
    }




}
