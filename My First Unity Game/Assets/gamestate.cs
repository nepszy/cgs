
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamestate : MonoBehaviour
{
    bool gamehasended = false;


    public GameObject levelUI;


    public void level()
    {
        Debug.Log("LEVEL COMPLETED");
        levelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Restart();
        }

        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}