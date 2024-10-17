
using System;
using System.Linq;
using UnityEngine;

public class SelectionOfSort : MonoBehaviour
{
    public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        Debug.LogFormat("�������� ������ {0}", "[" + string.Join(",", originalArray) + "]");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        Debug.LogFormat("��������� ���������� {0}", "[" + string.Join(",", sortedArray) + "]");

        int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
        Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "��������� ������" : "��������� �� ������");
    }

    private int[] SelectionSort(int[] array)
    {
        int index;
        int temp;

        for (int i = 0; i < array.Length; i++)
        {
            index = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[index])
                {
                    index = j;
                }
            }
            if (array[index] == array[i])
                continue;
            temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
        return array;
    }
}