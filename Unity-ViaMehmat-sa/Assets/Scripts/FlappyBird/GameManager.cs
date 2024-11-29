using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverMenu; // ������ �� ���� ��������� ����

    public void EndGame()
    {
        FindObjectOfType<RestartMenuManagerFB>().ShowRestartMenu(); // ���������� ���� �����������
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // ���������� �����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ������������� ������� �����
    }

    public void QuitGame()
    {
        Application.Quit(); // ����� �� ����
    }
}
