using UnityEngine;

public class Crow : MonoBehaviour
{
    public float flapForce = 5f; // ����, � ������� ������� ��������
    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // �������� ��������� Animator
    }

    void Update()
    {
        // ���������, ������ �� ������� ������� ��� ���
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(1))
        {
            Flap();
        }
    }

    void Flap()
    {
        rb.velocity = Vector2.up * flapForce; // ��������� ���� � �������
        animator.SetTrigger("Fly"); // ��������� �������� ������
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ����� ����� ���������� ������, ����� ������� ������������ � ������������
        Debug.Log("Game Over!");
        FindObjectOfType<GameManager>().EndGame(); // �������� ����� ���������� ����
    }
}