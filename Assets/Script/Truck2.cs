using UnityEngine;

public class Truck2 : MonoBehaviour
{
    public string trashType;


    public void CollectTrash(string trashTypeFromTrash)
    {
        // ¬ыполните нужные операции с типом мусора
        Debug.Log("ћусор типа " + trashTypeFromTrash + " собран камазом!");
        trashType = trashTypeFromTrash;
    }
    public void DepositTrash()
    {
        // ¬ыполните нужные операции дл€ "положени€" мусора
        Debug.Log("ћусор типа " + trashType + " успешно положен в мусорный бак!");
    }
    // ...
}