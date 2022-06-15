using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public InputField playerName;
    public void Name(){DataManager.Instance.namee = playerName.text;}
    public void Play(){SceneManager.LoadScene(1);}
    public void Quit(){Application.Quit();}
}
