using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuanSceneManager : MonoBehaviour
{
    public void GameLoadScene(string level)
    {
        SceneManager.LoadScene(level);
    }
   
    }
