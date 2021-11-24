using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class FoodCollison : MonoBehaviour
{

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "subPlayer")
        {
            int nextHealth = LookChanger.GetInstance().playerHealth + 1;
            LookChanger.SetNewHealth(nextHealth);
            Destroy(gameObject);
            // IF SPEED INCREASES WITH POINTS
            //FindObjectOfType<PathCreation.Examples.PathFollower>().speed + 0.25f;
        }
    }
}
