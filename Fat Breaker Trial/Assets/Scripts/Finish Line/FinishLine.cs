using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class FinishLine : MonoBehaviour
{
    public GameObject basket;
    public Camera camm;
    public float speed = 5f;
   
    private void OnTriggerEnter(Collider other)
    {
        Vector3 basketPosition = basket.transform.position;
        Vector3 jumpWay = basketPosition - transform.position + new Vector3(0, 12, 0);        
        if (other.tag == "Player" || other.tag == "subPlayer")
        {
            if (other.tag == "Player")
            {
                Rigidbody tempRigid = other.gameObject.GetComponent<Rigidbody>();
                tempRigid.AddForce(Vector3.up * 4000f);
                
                tempRigid.AddForce(jumpWay * 2500f);
                Camera.main.transform.parent = null;
                tempRigid.useGravity = true;
            }
            if (other.tag == "subPlayer")
            {
                Rigidbody tempRigid = other.gameObject.GetComponentInParent<Rigidbody>();
                tempRigid.AddForce(Vector3.up * 4000f);
                
                tempRigid.AddForce(jumpWay*1000f);
                Camera.main.transform.parent = null;
                tempRigid.useGravity = true;
            }
        }
        FindObjectOfType<StartGameUI>().ShowNextLevelUI();
        camm.transform.RotateAround(basketPosition, Vector3.up, 20f * Time.deltaTime);
    }
}
