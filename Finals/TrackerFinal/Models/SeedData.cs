using Microsoft.AspNetCore.Components.Forms;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;

namespace TrackerFinal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<FinalContext>>()))
            {
                if (context == null || context.Students == null)
                {
                    throw new ArgumentNullException("Null CreditContext");
                }
                if (context.Students.Any())
                {
                    return;
                }

                context.Students.Add(new Student
                {
                    Fullname = "Рыбин Никита Сергеевич",
                    Math = 4,
                    Russian = 5,
                    English = 5,
                    Chemistry = 3
                });
                context.Students.Add(new Student
                {
                    Fullname = "Иванова Валерия Анатольевна",
                    Math = 5,
                    Russian = 5,
                    English = 5,
                    Chemistry = 4
                });
                context.Students.Add(new Student
                {
                    Fullname = "Федорчук Антон Дмитриевич",
                    Math = 4,
                    Russian = 4,
                    English = 4,
                    Chemistry = 3
                });
                context.Students.Add(new Student
                {
                    Fullname = "Герасимов Владислав Фёдорович",
                    Math = 5,
                    Russian = 4,
                    English = 4,
                    Chemistry = 5
                });
                context.Students.Add(new Student
                {
                    Fullname = "Адыев Данил Олегович",
                    Math = 5,
                    Russian = 3,
                    English = 4,
                    Chemistry = 3
                });
                context.Students.Add(new Student
                {
                    Fullname = "Павленко Жанна Аркадиевна",
                    Math = 4,
                    Russian = 4,
                    English = 5,
                    Chemistry = 3
                });
                context.Students.Add(new Student
                {
                    Fullname = "Сидоренко Евгений Петрович",
                    Math = 5,
                    Russian = 5,
                    English = 5,
                    Chemistry = 4
                });
                context.Students.Add(new Student
                {
                    Fullname = "Данилов Антон Сергеевич",
                    Math = 5,
                    Russian = 5,
                    English = 5,
                    Chemistry = 5
                });
                context.SaveChanges();
            }
        }
    }
}
