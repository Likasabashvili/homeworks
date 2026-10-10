namespace ListAndDictionary;

class Program
{
    static void Main(string[] args)
    {

        List<string> students = new List<string>
        {
            "Lika",
            "Nika",
            "Mariami",
            "Giorgi"
        };

        int[] scores = { 100, 95, 75, 80 };

        Dictionary<string, int> grades = new Dictionary<string, int>();

        for (int i = 0; i < students.Count; i++)
        {
            grades.Add(students[i], scores[i]);
        }

        foreach (var student in grades)
        {
            Console.WriteLine($"{student.Key} - {student.Value}");
        }

//studentis da misi qulis damateba
        AddStudent(students, grades);
        SearchStudent(grades);
        UpdateGrade(grades);
        ShowStudents(grades);
        
       

        static void AddStudent(List<string> students, Dictionary<string, int> grades)
        {
            Console.WriteLine("enter student name: ");
            string name = Console.ReadLine()!;

            if (grades.ContainsKey(name))
            {
                Console.WriteLine($"{name} already exists");
                return;
            }

            Console.WriteLine("enter grade: ");
            int score = int.Parse(Console.ReadLine()!);

            students.Add(name);
            grades.Add(name, score);

            Console.WriteLine("student added successfully");
        }

        //studentis modzebna
        static void SearchStudent (Dictionary<string, int> grades)
        {
            Console.WriteLine("\n enter student name to search:");
            string name = Console.ReadLine()!;

            if (grades.ContainsKey(name))
            {
                Console.WriteLine($"grade: {grades[name]}");
            }
            else
            {
                Console.WriteLine("student not found");
            }
        }
        //qulebis ganaxleba 
        static void UpdateGrade(Dictionary<string, int> grades)
        {
            Console.WriteLine("\n enter student name to update grade:");
            string name = Console.ReadLine()!;

            if (grades.ContainsKey(name))
            {
                Console.Write("enter new score:");
                int score = int.Parse(Console.ReadLine()!);
                
                grades[name] = score;

                Console.WriteLine("grade updated successfully");
            }
            else
            {
                Console.WriteLine("student not found");
            }
            
        }
        //studentebis gamotana 
        static void ShowStudents(Dictionary<string, int> grades)
        {
            Console.WriteLine("\n all students:");

            foreach (var student in grades)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
        }
    }

}