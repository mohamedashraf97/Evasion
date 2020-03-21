using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagement : MonoBehaviour
{
     bool GameHasEnded = false ;
	public float restartDelay = 1f ;
	public GameObject CompleteLevelUI;



public void Complete () {

CompleteLevelUI.SetActive(true); 


}

public void EndGame()
    {
        if (GameHasEnded == false)
        {

            GameHasEnded = true;


            Invoke("Restart",restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


	}
}
