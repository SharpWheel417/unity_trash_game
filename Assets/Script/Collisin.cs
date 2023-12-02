using System;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public string trashType; // Тип мусора
    public string tagKamaz; //Тег камаза


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(tagKamaz))
        {
            Truck truck = collision.gameObject.GetComponent<Truck>(); // Получаем скрипт Truck из объекта камаза
            truck.CollectTrash(trashType); // Вызываем метод CollectTrash у камаза и передаем тип мусора
            Destroy(gameObject); // Уничтожаем объект мусора
        }

    }
}