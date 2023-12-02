using TMPro;
using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public string trashType; // Тип мусорного бака
    public static int counter = 0; // Счетчик



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Truck"))
        {
            Truck truck = collision.gameObject.GetComponent<Truck>(); // Получаем скрипт Truck из объекта камаза
                GameObject counterObject = GameObject.FindWithTag("counter");
                TextMeshProUGUI counterText = counterObject.GetComponent<TextMeshProUGUI>();

            if (truck.trashType == trashType) // Сравниваем тип мусора в камазе с типом мусорного бака
            {
                truck.DepositTrash(); // Вызываем метод DepositTrash у камаза для "положения" мусора
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