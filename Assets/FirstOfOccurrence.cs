
using System.Linq;
using UnityEngine;

public class FirstOfOccurrence : MonoBehaviour
{
    public void OnFirstOccurrence()
    {
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOccurrence(array, value);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");

        array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        value = 55;
        want = -1;
        got = FirstOccurrence(array, value);
        message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");
    }

    private int FirstOccurrence(int[] array, int value)
    {
        int index = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                index = i;
                break;
            }
        }
        return index;
    }
}