using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextScene1());
    }

    IEnumerator LoadNextScene1()
    {
        yield return new WaitForSeconds(2.5f);
        int currentScenenIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScenenIndex + 1);
    }
}
