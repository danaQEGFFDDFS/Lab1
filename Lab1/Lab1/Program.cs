using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab1
{
    internal class Program
    {
       private static LabContext context = new LabContext();

        static void Retract(int id1, int id2, int amount)
        {
             
            Account name1 = context.Accounts.Where(c => c.IdAcc == id1).FirstOrDefault();
            Account name2 = context.Accounts.Where(c => c.IdAcc == id2).FirstOrDefault();
            name1.Balance -= amount;
            name2.Balance += amount;
            context.SaveChanges();
        }

        static void Retract2(int id1,int amount)
        {
            Account name1 = context.Accounts.Where(c => c.IdAcc == id1).FirstOrDefault();
            name1.Balance -= amount + amount/100;
           context.SaveChanges();
        }

        static void Main(string[] args)

        {
            context.Database.EnsureCreated();

            User user1 = new User { secondname = "Нургазиева Дана Руслановна" };
                User user2 = new User { secondname = "Иванов Сергей Александрович" };
                User user3 = new User {  secondname = "Петров Павел Андреевич" };
                // добавляем объекты  в контекст данных
                context.Users.Add(user1);
                context.Users.Add(user2);
                context.Users.Add(user3);
                // сохраняем контекст данных в базу данных
                context.SaveChanges();
            Account acc = new Account();
            Console.WriteLine("Введите номер аккаунта: ");
            acc.IdAcc = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество денег на счету: ");
            acc.Balance = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип банковского аккаунта");
            acc.TypeAccount = string.Format(Console.ReadLine());
            acc.User = user2;
            Console.WriteLine("Тип банковского аккаунта " + acc.TypeAccount + ", номер счета " + acc.IdAcc + ", количество " + acc.Balance+ acc.User);
            Console.ReadKey();
            context.Accounts.Add(acc);
            Account acc1 = new Account { IdAcc = 1, Balance = 1000, TypeAccount = "Валютный", User = user1};
            context.Accounts.Add(acc1);
            context.SaveChanges();
            Retract( 1, 2,30);
            
        }
    }
}
