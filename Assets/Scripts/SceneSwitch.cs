using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void SwitchScene(int myNumber)
    {
		StartCoroutine(LoadYourAsyncScene(myNumber));
    }

    IEnumerator LoadYourAsyncScene(int myNumber)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. 

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(myNumber);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}