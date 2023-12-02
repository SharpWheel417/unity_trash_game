using System;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public string trashType; // ��� ������
    public string tagKamaz; //��� ������


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(tagKamaz))
        {
            Truck truck = collision.gameObject.GetComponent<Truck>(); // �������� ������ Truck �� ������� ������
            truck.CollectTrash(trashType); // �������� ����� CollectTrash � ������ � �������� ��� ������
            Destroy(gameObject); // ���������� ������ ������
        }

    }
}