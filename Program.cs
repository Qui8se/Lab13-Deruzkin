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




// double CalculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//        sum += grade; 
//     }
//     return (double)sum / grades.Length;
// }

// int CountFives(int[] grades)
// {
//     int count = 0;
//     foreach (int grade in grades)
//     {
//         if (grade == 5)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// int[] grades = {4, 5, 3, 5, 4};
// double average = CalculateAverageGrade(grades);
// int fivesCount = CountFives(grades);

// Console.WriteLine(average);
// Console.WriteLine(fivesCount);






// Шаг 5

// class Program {
//     static void Main() {
//         // Вызовет первый вариант: int Add(int, int) -> 5
//         Console.WriteLine(Add(2, 3)); 
        
//         // Вызовет второй вариант: double Add(double, double) -> 6.0
//         Console.WriteLine(Add(2.5, 3.5)); 
        
//         // Вызовет третий вариант: int Add(int, int, int) -> 9
//         Console.WriteLine(Add(2, 3, 4)); 
//     }

//     static int Add(int a, int b) {
//         return a + b;
//     }

//     static double Add(double a, double b) {
//         return a + b;
//     }

//     static int Add(int a, int b, int c) {
//         return a + b + c;
//     }
// }







// Самостоятельные задания
// Задача А

// static void PrintDivider()
// {
//     Console.WriteLine("^_^");
// }
// Console.WriteLine("бубубубу");
// PrintDivider();
// Console.WriteLine("бубубубу");







// Задача Б

// static void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Имя: {name}, Возраст: {age} лет");
// }
// PrintPerson("Александр", 17);
// PrintPerson("Рита", 17);





// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");






// Вариант 4

// int[] numbers = {10, 20, 15, 5};

// int sum = 0;

// foreach(int num in numbers)
// {
//     sum +=num;
// }
// Console.WriteLine(sum);





// Вариант 7

// int[] numbers = {10, 20, 15, 5, 8};
// int minValue = FindMin(numbers);
// Console.WriteLine($"Минимальные число: {minValue}");


// int FindMin(int[] numbers)
// {
//     int min = numbers[0];
//     foreach (int n in numbers)
//     {
//         if (n < min) min = n;
//     }
//     return min;
// }
