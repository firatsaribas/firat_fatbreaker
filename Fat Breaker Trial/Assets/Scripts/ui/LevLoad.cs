using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevLoad : MonoBehaviour
{
    public int nextlevelToLoad;
    public int thisLevel;
    public void SameLevLoader()
    {
        SceneManager.LoadScene(thisLevel);
    }
    public void NextLevLoader()
    {
        SceneManager.LoadScene(nextlevelToLoad);
    }
}
