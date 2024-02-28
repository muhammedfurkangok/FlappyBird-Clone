using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;

   [SerializeField] private GameObject _gameOverScene;

   private void Awake()
   {
      if (instance == null)
      {
         instance = this;
      }

      Time.timeScale = 1f;
   }

   public void GameOver()
   {
      _gameOverScene.SetActive(true);
      Time.timeScale = 0;
   }

   public void RestartGame()
   {
      SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
   }

  
}
