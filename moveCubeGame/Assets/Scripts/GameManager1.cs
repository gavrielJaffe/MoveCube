using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    bool gameHasEnded = false ; 
    public float restartDelay = 1f ;
    public GameObject CompletLevelUI;
    
    
    public void CompletLevel()
    {
        CompletLevelUI.SetActive(true);
    }

    public void EndGame () 
    {
        if (gameHasEnded == false )
        {
            gameHasEnded = true ; 
            Debug.Log("GAME OVER !");
            Invoke("Restart" , restartDelay);
        }
    }
    
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
