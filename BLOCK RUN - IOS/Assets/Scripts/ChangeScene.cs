using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject music;
    public void btn_change_scene()
    {
        Debug.Log("Clicked");
        SceneManager.LoadScene(1);
    }
}
