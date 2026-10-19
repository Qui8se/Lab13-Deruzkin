//Шаг 1

// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабараторная работа №13");
//     Console.WriteLine("0_0");
// }

// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("Конец программы");
//     Console.WriteLine("X_X");
//     Console.WriteLine("Дата формирования отчёта: 23:34");
// }







// Шаг 2

// void PrintStudentCard(string name, int age, string group)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
// }

// PrintStudentCard("Егор", 18, "ИСП-251");
// PrintStudentCard("Валерия", 17, "ИСП-251");







// Шаг 3

// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }


// bool IsEligibleForBonus(double averageGrade)
// {
//     return averageGrade >= 4.5;
// }


// double studentAverageGrade = 4.7;
// double scholarshipAmount;

// if (IsEligibleForBonus(studentAverageGrade))
// {
//     scholarshipAmount = CalculateScholarship(2000, 15);
//     Console.WriteLine("Студент получает надбавку");
// } 
// else
// {
//     scholarshipAmount = CalculateScholarship(2000, 15);
//     Console.WriteLine("Студент не получает надбавку");
// }
// double result = CalculateScholarship(2000, 15);
// Console.WriteLine($"Итоговая стипендия: {scholarshipAmount}");










// Шаг 4


using System.ComponentModel;

double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
       sum += grade; 
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades)
{
    int count = 0;
    foreach (int grade in grades)
    {
        if (grade == 5)
        {
            count++;
        }
    }
    return count;
}


int[] grades = {4, 5, 3, 5, 4};
double average = CalculateAverageGrade(grades);
int fivesCount = CountFives(grades);

Console.WriteLine(average);
Console.WriteLine(fivesCount);