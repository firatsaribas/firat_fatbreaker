using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    public GameObject breakbaleWall;
    private void OnTriggerEnter(Collider other)
    {
        int temphealth = LookChanger.GetInstance().playerHealth;
        if (other.tag == "Player" || other.tag == "subPlayer")
        {
            if (temphealth >= 4)
            {
                
                GameObject tempWall = Instantiate(breakbaleWall, gameObject.transform.position, gameObject.transform.rotation);
                Destroy(gameObject);


            }
            if (temphealth < 4)
            {
                //Rigidbody tempRigid = other.gameObject.GetComponent<Rigidbody>();
                //tempRigid.AddForce(Vector3.back * 5000f);
                //tempRigid.angularVelocity = Vector3.left;
                Destroy(other.gameObject);
                FindObjectOfType<StartGameUI>().RetryUI();
                Camera.main.transform.parent = null;
            }
            LookChanger.SetNewHealth(1);
        }
    }
}
