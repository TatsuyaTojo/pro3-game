using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClearGame : MonoBehaviour {

    public void Clear()
    {
        SceneManager.LoadScene("end");

        }
    }
