using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rotate_by_tap_no_handles : MonoBehaviour
{
    void check_rot0 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation == target0) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }

    void check_rot90 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation == target90) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }
    void check_rot180 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation == target180) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }
    void check_rot270 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation == target270) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }

    void all_rot_check () {
        global.partChecker = 0;
      //  Debug.Log (global.partChecker);
        check_rot180(obj1, "1_1");
      //  Debug.Log (global.partChecker);
        check_rot180(obj2, "1_2");
      //  Debug.Log (global.partChecker);
        check_rot270(obj3, "1_3");
      //  Debug.Log (global.partChecker);
        check_rot270(obj4, "1_4");
       // Debug.Log (global.partChecker);

        check_rot270(obj5, "1_5");
       // Debug.Log (global.partChecker);
        check_rot180(obj6, "1_6");
      //  Debug.Log (global.partChecker);
        check_rot270(obj7, "1_7");
      //  Debug.Log (global.partChecker);
        check_rot180(obj8, "1_8");
     //   Debug.Log (global.partChecker);

        check_rot0(obj9, "1_9");
      //  Debug.Log (global.partChecker);
        check_rot90(obj10, "1_10");
      //  Debug.Log (global.partChecker);
        check_rot0(obj11, "1_11");
      //  Debug.Log (global.partChecker);
        check_rot90(obj12, "1_12");
      //  Debug.Log (global.partChecker);
        
        check_rot90(obj13, "1_13");
       // Debug.Log (global.partChecker);
        check_rot90(obj14, "1_14");
       // Debug.Log (global.partChecker);
        check_rot0(obj15, "1_15");
       // Debug.Log (global.partChecker);
        check_rot0(obj16, "1_16");
       // Debug.Log (global.partChecker);
    }


   // private int partChecker = 0, rowChecker = 0; 
    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16;
    //public GameObject row1, row2, row3, row4;
    Quaternion target0 = Quaternion.Euler(0, 0, 0);
    Quaternion target90 = Quaternion.Euler(0, 0, -90);
    Quaternion target180 = Quaternion.Euler(0, 0, 180);
    Quaternion target270 = Quaternion.Euler(0, 0, 90);

    public GameObject part;

   // void OnMouseDown() {
   //     part.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
   //     Debug.Log (part.transform.rotation.eulerAngles.z);
   // }

    void OnMouseUp() { 
        //global.partChecker = 0;
        //global.rowChecker = 0;
       // all_rot_check ();
        //Debug.Log (global.partChecker);
      //  if (global.rowChecker==1 & global.partChecker==16){
            //global.staticChecker = true;
           // Debug.Log (global.staticChecker);
       //     SceneManager.LoadScene("congrats");
      //  } 
        this.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self); 
        //Debug.Log (transform.rotation.eulerAngles.z);  
        all_rot_check ();
        //Debug.Log (global.partChecker);
        if (global.partChecker==16){
            //global.staticChecker = true;
           // Debug.Log (global.staticChecker);
            SceneManager.LoadScene("congrats");
        }      
        //Debug.Log (global.rowChecker);
        
    }
}