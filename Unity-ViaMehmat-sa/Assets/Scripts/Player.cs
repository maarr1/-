using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed; // �������� ��������
    public int coins; // ���������� �����

    private Animator animator; // ��������
    private SpriteRenderer spriteRenderer; // ������-��������
    private Rigidbody2D rigidBody2D; // ���������
    private GroundCollider groundCollider; // �������� ��� ����������� �������� � ������������

    // ���������� ����� ������ ������
    void Start()
    {
        animator = GetComponent<Animator>(); // ��������� ���������� Animator
        spriteRenderer = GetComponent<SpriteRenderer>(); // ��������� ���������� SpriteRenderer
        rigidBody2D = GetComponent<Rigidbody2D>(); // ��������� ���������� Rigidbody2D
        groundCollider = GetComponentInChildren<GroundCollider>(); // ��������� ���������� GroundCollider
    }

    // ���������� ������ ����
    void Update()
    {
        float movement_x = Input.GetAxis("Horizontal"); // ��������� �������� ��������������� ��������
        // �� ������ ���������� float movement_y = Input.GetAxis("Vertical"); // ��������� �������� ������������� ��������
        transform.position += new Vector3(movement_x, 0, 0) Time.deltaTime moveSpeed; // ����������� ��������� �� �����������

        // ��������������� ������� � ����������� �� ����������� ��������
        if (movement_x > 0)
        {
            spriteRenderer.flipX = false; // �� �������������� ������
        }
        if (movement_x < 0)
        {
            spriteRenderer.flipX = true; // ����������� ������
        }

        // �������� ������, ���� �������� �� ����� � ���������
        if (movement_x != 0 && groundCollider.OnGround())
        {
            animator.SetInteger("State", 1); // ������ �������� ������
        }

        // �������� �������, ���� �������� �� ����� � �� ���������
        if (movement_x == 0 && groundCollider.OnGround())
        {
            animator.SetInteger("State", 0); // ������ �������� �������
        }
    }

    // ���������� ����� � �����
    public void AddCoins(int number)
    {
        coins += number;
    }
}
