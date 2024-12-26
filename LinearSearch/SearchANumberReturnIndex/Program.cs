int[] dataArray = { 1, 3, 5, 7, 9 }; // Mảng kiểm tra

Algorithms alg = new Algorithms(); // Khởi tạo đối tượng Algorithms

// Gọi hàm LinearSearchIndex và in kết quả
int r1 = alg.LinearSearchIndex(dataArray, 5); // Kết quả: 2
int r2 = alg.LinearSearchIndex(dataArray, 8); // Kết quả: -1

Console.WriteLine($"TargetValue: 5. Index: {r1}");
Console.WriteLine($"TargetValue: 8. Index: {r2}");

public class Algorithms
{
    public int LinearSearchIndex(int[] numbers, int targetValue)
    {
        if (numbers is null)
        {
            throw new ArgumentNullException("numbers is null");
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == targetValue)
                return i;
        }

        return -1;
    }
}