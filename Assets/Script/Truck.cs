using UnityEngine;

public class Truck : MonoBehaviour
{
    public string trashType;


    public void CollectTrash(string trashTypeFromTrash)
    {
        // ��������� ������ �������� � ����� ������
        Debug.Log("����� ���� " + trashTypeFromTrash + " ������ �������!");
        trashType = trashTypeFromTrash;
    }
    public void DepositTrash()
    {
        // ��������� ������ �������� ��� "���������" ������
        Debug.Log("����� ���� " + trashType + " ������� ������� � �������� ���!");
    }
    // ...
}