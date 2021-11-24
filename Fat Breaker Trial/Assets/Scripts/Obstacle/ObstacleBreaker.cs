using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBreaker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" )
        {
            Destroy(other.gameObject);
            FindObjectOfType<StartGameUI>().RetryUI();
            Camera.main.transform.parent = null;
            //Rigidbody tempRigid = other.gameObject.GetComponent<Rigidbody>();
            //tempRigid.AddForce(Vector3.back * 5000f);
            //tempRigid.angularVelocity = Vector3.left;
        }
        if (other.tag == "subPlayer")
        {
            int nextHealth = LookChanger.GetInstance().playerHealth - 1;
            LookChanger.SetNewHealth(nextHealth);
            //Destroy(other.gameObject);
            //Camera.main.transform.parent = null;
        }

    }
}
