using System.Linq;
using UnityEngine;
public class SumOfEvenNumbersInRange : MonoBehaviour
{
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        var want = 98;
        int got = SumEvenNumbersInRange(min, max);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � ��������� �� {min} �� {max} ������������: {got} - {message}");
    }
    
    private int SumEvenNumbersInRange(int min, int max)
    {
        int sum = 0;
        for (int i = 7; i <= 21; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }        
        return sum;
    }
}