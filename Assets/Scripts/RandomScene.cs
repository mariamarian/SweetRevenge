
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomScene : MonoBehaviour
{
    public string[] scenes = new string[3];

    void OnMouseDown()
    {
        int randomIndex = Random.Range(0, scenes.Length);

        SceneManager.LoadScene(scenes[randomIndex]);
    }
}
