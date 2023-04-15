using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreferredSceneLoad : MonoBehaviour
{
    public void LoadNextScene(int indexLoad)
    {
        SceneManager.LoadScene(indexLoad);
    }
}
