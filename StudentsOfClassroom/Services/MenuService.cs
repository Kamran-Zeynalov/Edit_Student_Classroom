using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTables;
using System.Threading.Tasks;

namespace StudentsOfClassroom.Services
{
    internal class MenuService
    {
        private static ClassroomService classroomService = new();

        public static void MenuAddClassroom()
        {
            try
            {
                Console.WriteLine("Enter classroom's name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter classroom's subject:");
                string subject = Console.ReadLine()!;

                int classRoomId = classroomService.AddClassroom(name, subject);

                Console.WriteLine($"Classroom with ID:{classRoomId} was created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuDeleteClassroom()
        {
            try
            {
                Console.WriteLine("Enter classroom's id:");
                int id = int.Parse(Console.ReadLine()!);

                classroomService.DeleteClassroom(id);

                Console.WriteLine($"Classroom with ID:{id} was deleted!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuShowClassrooms()
        {
            var table = new ConsoleTable("ID", "Name", "Subject");

            foreach (var classroom in classroomService.ShowClassrooms())
            {
                table.AddRow(classroom.Id, classroom.Name, classroom.Subject);
            }

            table.Write();
        }
        public static void MenuUpdateClassroom()
        {
            try
            {
                Console.WriteLine("Enter classroom's Id:");
                int id = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter classroom's new name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter classroom's new subject:");
                string subject = Console.ReadLine()!;

                classroomService.UpdateClassroom(id, name, subject);

                Console.WriteLine($"Classroom with ID:{id} was Updated!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuAddStudent()
        {
            try
            {
                Console.WriteLine("Enter student's name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter student's surname:");
                string surname = Console.ReadLine()!;

                Console.WriteLine("Enter student's birthday (MM/dd/yyyy):");
                DateOnly birthday = DateOnly.Parse(Console.ReadLine()!);

                int studentId = classroomService.AddStudent(name, surname, birthday);

                Console.WriteLine($"Student with ID:{studentId} was created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuDeleteStudent()
        {
            try
            {
                Console.WriteLine("Enter students's id:");
                int id = int.Parse(Console.ReadLine()!);

                classroomService.DeleteStudent(id);

                Console.WriteLine($"Student with ID:{id} was deleted!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuShowStudents()
        {
            var table = new ConsoleTable("ID", "Name", "Surname", "Birthday");

            foreach (var student in classroomService.ShowStudents())
            {
                table.AddRow(student.Id, student.Name, student.Surname, student.Birthday);
            }

            table.Write();
        }

        public static void MenuUpdateStudents()
        {
            try
            {
                Console.WriteLine("Enter student's Id:");
                int id = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter student's new name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter student's new surname:");
                string surname = Console.ReadLine()!;

                Console.WriteLine("Enter student's new birthday (MM/dd/yyyy):");
                DateOnly birthday = DateOnly.Parse(Console.ReadLine()!);

                classroomService.UpdateStudent(id, name, surname, birthday);

                Console.WriteLine($"Student with ID:{id} was updated!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}
