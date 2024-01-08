using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void PlayGame(string LvlList)
    {
        SceneManager.LoadScene(LvlList);
    }
}
