using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookChanger : MonoBehaviour
{
    public GameObject shpere1;
    public GameObject shpere2;
    public GameObject shpere3;
    public void LookChange(int i)
    {
        //could have used switch cases here
        if (i==1)
        {
            shpere1.SetActive(false);
            shpere2.SetActive(false);
            shpere3.SetActive(false);
        }
        if (i == 2)
        {
            shpere1.SetActive(true);
            shpere2.SetActive(false);
            shpere3.SetActive(false);
        }
        if (i == 3)
        {
            shpere1.SetActive(false);
            shpere2.SetActive(true);
            shpere3.SetActive(false);
        }
        if (i == 4)
        {
            shpere1.SetActive(false);
            shpere2.SetActive(false);
            shpere3.SetActive(true);
        }
    }
    public int playerHealth;
    private void HealthCheck()
    {
        if (playerHealth == 1)
        {
            LookChange(1);
        }
        if (playerHealth == 2)
        {
            LookChange(2);
        }
        if (playerHealth == 3)
        {
            LookChange(3);
        }
        if (playerHealth == 4)
        {
            LookChange(4);
        }
    }
    void Update()
    {
        HealthCheck();
        SetBothHealth();
    }

    //public int healthPlayer;
    private static LookChanger instance;
    public static LookChanger GetInstance()
    {
        return instance;
    }
    private void Awake()
    {
        instance = this;
    }
    static int someHealth;
    public static void SetNewHealth(int health)
    {
        someHealth = health;
    }
    private void SetBothHealth()
    {
        playerHealth = someHealth;
    }
}
