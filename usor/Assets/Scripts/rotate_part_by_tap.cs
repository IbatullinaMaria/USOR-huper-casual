using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rotate_part_by_tap : MonoBehaviour
{
    //public GameObject part;
   // public int zRotation = 90;
   // public float timer = 100f;

    //void OnMouseDown () {
   //     part.transform.Rotate(0, 0, zRotation*Time.deltaTime);
   //     timer += Time.deltaTime;
   // } 
   // private float speed=10, tilt=10f, rot=0;
    //private Vector3 target = new Vector3 (0, 2f, 0);
    // Quaternion target = Quaternion.Euler(0, 0, -90);

    //private float timeCount = 0.0f;
    /*void OnMouseUp() {
        while (target.z != 90f) {
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * speed);
            target.z = target.z + 10f;
        }
    }*/
   /* void Update()
    {   
       // if (Input.GetMouseButtonU(0)){
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * speed);
            target.z = target.z + 10f;
        //}
        
    }*/
        
   // }
    /*void Update (float rot1) {
        if (Input.GetMouseButtonUp(1)){
            while (transform.rotation != Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * speed)){
                transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * speed);
            //if (transform.rotation == target && target.z != 90f)
             //   target.z = 10f;
           // else if (transform.rotation == target && target.z == 90f)
            //    target.z = 5f;
                transform.Rotate (Vector3.back * tilt);
            }
            
        }
        
            
    }*/
    //}

   /* public Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["spin"].layer = 1;
    }

     void Update()
    {
        // leave spin or jump to complete before changing
        if (anim.isPlaying)
        {
            return;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Spinning");
            anim.Play("spin");
        }
    }*/
   /* public Transform go;
    public float timer;
    public float speed;

    private float endTime = 0F;
    Quaternion target = Quaternion.Euler(0, 0, -90), target1 = Quaternion.Euler(0, 0, -180);
    
    void Update () {

            if (Input.GetMouseButtonUp(0))
                    endTime = Time.time + timer;
           // else if (transform.rotation == target)
            //        endTime = 0F;


            if (endTime > Time.time && transform.rotation != target)
                    //go.Rotate(Vector3.back, speed * Time.deltaTime);
                    go.transform.Rotate(0, 0, -10);
    }*/
    void check_rot0 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation.eulerAngles == vector0) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }

    void check_rot90 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation.eulerAngles == vector90) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }
    void check_rot180 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation.eulerAngles == vector180) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }
    void check_rot270 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation.eulerAngles == vector270) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }

    void all_rot_check () {
        global.partChecker = 0;
      //  Debug.Log (global.partChecker);
        check_rot0(obj1, "1_1");
      //  Debug.Log (global.partChecker);
        check_rot270(obj2, "1_2");
      //  Debug.Log (global.partChecker);
        check_rot180(obj3, "1_3");
      //  Debug.Log (global.partChecker);
        check_rot90(obj4, "1_4");
       // Debug.Log (global.partChecker);

        check_rot90(obj5, "1_5");
       // Debug.Log (global.partChecker);
        check_rot180(obj6, "1_6");
      //  Debug.Log (global.partChecker);
        check_rot270(obj7, "1_7");
      //  Debug.Log (global.partChecker);
        check_rot0(obj8, "1_8");
     //   Debug.Log (global.partChecker);

        check_rot180(obj9, "1_9");
      //  Debug.Log (global.partChecker);
        check_rot90(obj10, "1_10");
      //  Debug.Log (global.partChecker);
        check_rot0(obj11, "1_11");
      //  Debug.Log (global.partChecker);
        check_rot270(obj12, "1_12");
      //  Debug.Log (global.partChecker);
        
        check_rot270(obj13, "1_13");
       // Debug.Log (global.partChecker);
        check_rot0(obj14, "1_14");
       // Debug.Log (global.partChecker);
        check_rot90(obj15, "1_15");
       // Debug.Log (global.partChecker);
        check_rot180(obj16, "1_16");
       // Debug.Log (global.partChecker);
    }


   // private int partChecker = 0, rowChecker = 0; 
    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16;
    //public GameObject row1, row2, row3, row4;
   // Quaternion target0 = Quaternion.Euler(0, 0, 0);
   // Quaternion target90 = Quaternion.Euler(0, 0, -90);
   // Quaternion target180 = Quaternion.Euler(0, 0, 180);
   // Quaternion target270 = Quaternion.Euler(0, 0, 90);


    Vector3 vector0= new Vector3(0, 0, 0);
    Vector3 vector90= new Vector3(0, 0, 270);
    Vector3 vector180= new Vector3(0, 0, 180);
    Vector3 vector270= new Vector3(0, 0, 90);
    public GameObject part;
    


   // void OnMouseDown() {
   //     part.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
   //     Debug.Log (part.transform.rotation.eulerAngles.z);
   // }

    public void OnMouseUp() { 
        //global.partChecker = 0;
        //global.rowChecker = 0;
       // all_rot_check ();
        //Debug.Log (global.partChecker);
      //  if (global.rowChecker==1 & global.partChecker==16){
            //global.staticChecker = true;
           // Debug.Log (global.staticChecker);
       //     SceneManager.LoadScene("congrats");
      //  } 
        this.transform.Rotate(0, 0, -90); 
       // Debug.Log (transform.rotation.eulerAngles.z);  
       //Debug.Log (transform.rotation.eulerAngles);
        all_rot_check ();
        //Debug.Log (global.partChecker);
        if (global.rowChecker==1 & global.partChecker==16){
            //global.staticChecker = true;
           // Debug.Log (global.staticChecker);
            SceneManager.LoadScene("congrats");
        }      
        //Debug.Log (global.rowChecker);
        
    }

}
