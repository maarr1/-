using UnityEngine;
using UnityEngine.SceneManagement; // ��� �������� �����
using UnityEngine.UI; // ��� ������ � UI

public class DeadZone : MonoBehaviour
{
    public GameObject RestartMenu; // ������ �� ���� ����������


    public void ShowRestartMenu()
    {
        // ��������� ���� �����������
        Time.timeScale = 0; // ������������� ����
        RestartMenu.SetActive(true);
    }

    public void RestartGame()
    {
        // ���������� �����
        Time.timeScale = 1;
        // ������������� ������� �����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        // ����� �� ����
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // ������������� ���� � ���������
#endif
    }
}
