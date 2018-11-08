using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectObj : MonoBehaviour {
  
   
    public GameObject snapobject;
    bool turnColorONFF = false;
        

    void OnTriggerEnter(Collider col)
    {

        Collider[] slots = Physics.OverlapSphere(col.transform.position, 5,9);

        turnColorONFF = true;
        RenderColor(turnColorONFF);

 
       

            for (int i = 0; i < slots.Length; i++)
            {
                if (snapobject.name == slots[i].name)
                {
                       snapobject.transform.position = this.transform.position;
                snapobject.GetComponent<Movement>().enabled = false;
                        

            }



            // Debug.Log("collier is triggered" + col.tag);
            //if (!GetComponent<FixedJoint>())
            //    {
            //        this.gameObject.AddComponent<FixedJoint>();
            //        var joint = GetComponent<FixedJoint>();
            //        joint.connectedBody = snapobject.GetComponent<Rigidbody>();
            //        isComplete = true;
            //    }


            }
     
    }
   


    private void OnTriggerExit(Collider col)
    {
        turnColorONFF = false;
        RenderColor(turnColorONFF);
    }
    void RenderColor(bool onoff)
    {

    Renderer[] objRend = GetComponentsInChildren<Renderer>();
       
            foreach (Renderer r in objRend)
            {
                Material m = r.material;
                if (onoff)
                {
                     m.color = Color.green;
                }
                else
                {
                     m.color = Color.white;
                }

            r.material = m;
            
            }
    
    }
}
