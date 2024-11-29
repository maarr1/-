using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenuManagerFB : MonoBehaviour
{
    public GameObject restartMenu; // ������ �� ������ ���� �����������

    // ����� ��� ����������� ���� �����������
    public void ShowRestartMenu()
    {
        restartMenu.SetActive(true); // ���������� ���� �����������
        Time.timeScale = 0; // ������������� ����� � ����
    }

    // ����� ��� ����������� ����
    public void RestartGame()
    {
        Time.timeScale = 1; // ���������� ����� � ����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ������������� ������� �����
    }

    // ����� ��� ������ �� ����
    public void QuitGame()
    {
        Application.Quit(); // ����� �� ����
    }
}
