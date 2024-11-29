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
  
    // ���������� ����� ������ ������
    void Start()
    {
        animator = GetComponent<Animator>(); // ��������� ���������� Animator
        spriteRenderer = GetComponent<SpriteRenderer>(); // ��������� ���������� SpriteRenderer
        rigidBody2D = GetComponent<Rigidbody2D>(); // ��������� ���������� Rigidbody2D
    }

    // ���������� ������ ����
    void Update()
    {
        float movement_x = Input.GetAxis("Horizontal"); // ��������� �������� ��������������� ��������
        // �� ������ ���������� float movement_y = Input.GetAxis("Vertical"); // ��������� �������� ������������� ��������

        // ��������������� ������� � ����������� �� ����������� ��������
        if (movement_x > 0)
        {
            spriteRenderer.flipX = false; // �� �������������� ������
        }
        if (movement_x < 0)
        {
            spriteRenderer.flipX = true; // ����������� ������
        }

    }

    // ���������� ����� � �����
    public void AddCoins(int number)
    {
        coins += number;
    }
}
