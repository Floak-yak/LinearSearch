int[] dataArray = { 1, 3, 5, 7, 9 }; // Tạo một mảng số nguyên để kiểm tra

Algorithms alg = new Algorithms(); // Khởi tạo đối tượng của lớp Algorithms

// Gọi hàm LinearSearch và in kết quả
bool r1 = alg.LinearSearch(dataArray, 5); // Kết quả: True
bool r2 = alg.LinearSearch(dataArray, 8); // Kết quả: False

Console.WriteLine($"TargetValue: 5. Found: {r1}");
Console.WriteLine($"TargetValue: 8. Found: {r2}");

public class Algorithms
{
    public bool LinearSearch(int[] numbers, int targetValue)
    {
        if(numbers is null)
        {
            throw new ArgumentNullException("numbers is null");
        }
        
        foreach (int number in numbers)
        {
            if (number == targetValue)
                return true;
        }
        return false;
    }
}
