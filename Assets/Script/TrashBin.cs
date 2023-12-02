using TMPro;
using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public string trashType; // ��� ��������� ����
    public static int counter = 0; // �������



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Truck"))
        {
            Truck truck = collision.gameObject.GetComponent<Truck>(); // �������� ������ Truck �� ������� ������
                GameObject counterObject = GameObject.FindWithTag("counter");
                TextMeshProUGUI counterText = counterObject.GetComponent<TextMeshProUGUI>();

            if (truck.trashType == trashType) // ���������� ��� ������ � ������ � ����� ��������� ����
            {
                truck.DepositTrash(); // �������� ����� DepositTrash � ������ ��� "���������" ������
                truck.trashType = "";


                counter++;
                counterText.text = counter.ToString();
            }
            else
            {
                truck.trashType = "";
                counter--;
                counterText.text = counter.ToString();
            }
        }
    }
}