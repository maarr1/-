using UnityEngine;
using UnityEngine.SceneManagement; // ��� �������� �����
using UnityEngine.UI; // ��� ������ � UI

public class DeadZone : MonoBehaviour
{
    public GameObject restartMenu; // ������ �� ���� �����������

    private void OnTriggerEnter(Collider other)
    {
        // ���������, ���� ������, �������� � ����, �������� �������
        if (other.CompareTag("Crow"))
        {
            // ��������� ���� �����������
            ShowRestartMenu();
        }
    }

    private void ShowRestartMenu()
    {
        // ��������� ���� �����������
        restartMenu.SetActive(true);
        Time.timeScale = 0; // ������������� ����
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
