using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] int levelNumber;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameplayStatics.GetPlayerGameObject())
        {
            PlayerPrefs.SetInt("level", levelNumber);
            PlayerPrefs.Save();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}