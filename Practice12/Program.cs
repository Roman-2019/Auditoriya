using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
             int[] massiv = new int[4];

            Admin admin = new Admin();
            Auditorii Auditoriya1 = new Auditorii();
            Auditoriya1.Counter = admin.ProverkaAuditorii(value);
            massiv[0] = Auditoriya1.Counter;
            Auditorii Auditoriya2 = new Auditorii();
            Auditoriya2.Counter = admin.ProverkaAuditorii(value);
            massiv[1] = Auditoriya2.Counter;
            Auditorii Auditoriya3 = new Auditorii();
            Auditoriya3.Counter = admin.ProverkaAuditorii(value);
            massiv[2] = Auditoriya3.Counter;
            Auditorii Auditoriya4 = new Auditorii();
            Auditoriya4.Counter = admin.ProverkaAuditorii(value);
            massiv[3] = Auditoriya4.Counter;

            Console.WriteLine($"{Auditoriya1.Counter}, {Auditoriya2.Counter}, {Auditoriya3.Counter}, {Auditoriya4.Counter}");
            Console.Read();

            var auditoriya = new Auditorii();

            Console.WriteLine("Menu:\nEnter - Add Student\nEsc - Exit");
            var commands = new Dictionary<ConsoleKey, ICommand>
            {
                [ConsoleKey.Enter] = new Auditoriyas(auditoriya),
                //[ConsoleKey.Escape] = new Status(),
            };

            Human t = new Human();
            var menu = true;
            while (menu)
            {
                var key = Console.ReadKey().Key;
                if (!commands.ContainsKey(key))
                    break;

                var selectedCommand = commands[key];
                if (massiv[0]-1 > 0)
                {
                    selectedCommand.AddStudent(massiv[0]);
                    massiv[0]--;
                    Console.WriteLine($"In first auditorii {Auditoriya1.Counter-1} places and {massiv[0]- t.Teacher} free places");
                    continue;
                }
                else if (massiv[1]-1 > 0) 
                {
                    selectedCommand.AddStudent(massiv[1]);
                    massiv[1]--;
                    Console.WriteLine($"In second auditorii {Auditoriya2.Counter-1} places and {massiv[1]- t.Teacher} free places");
                    continue;
                }
                else if (massiv[2]-1 > 0)
                {
                    selectedCommand.AddStudent(massiv[2]);
                    massiv[2]--;
                    Console.WriteLine($"In third auditorii {Auditoriya3.Counter-1} places and {massiv[2]- t.Teacher} free places");
                    continue;

                }
                else if (massiv[3]-1 > 0)
                {
                    selectedCommand.AddStudent(massiv[3]);
                    massiv[3]--;
                    Console.WriteLine($"In forth auditorii {Auditoriya4.Counter-1} places and {massiv[3]- t.Teacher} free places");
                    continue;
                }
            }

            
            //auditoriya.AddStudent();
        }
        public void status() { }
    }

    
}
/*Класс, админ, учитель, ученики
 есть 4 аудитории - создаем в программс 4 списка
 1)админ умеет  провести оценку аудитории
 2)аудитория можетбыть оцененнатолько админом(паблик метод (гет;прайвет сет)) отдельный метод сета , который делает админ) и ее вместительность
 или  запускать в себя студентов и котролиорвать процесс
 3) препод (тоже человек)- может быть максимум 1 в аудитории (абстрактный класс человек)
 4) студент (человек)
     */
