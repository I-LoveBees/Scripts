using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneSwitchBehavior : MonoBehaviour
{
    public string sceneName;
    
    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
