using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using PrimeTime.Models;

namespace PrimeTime.Utils
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder, IStringLocalizer<SkillLevel> localizer)
        {

            //Заполнение таблицы "SkillLevels" в БД приложения данными из файла ресурсов SkillLevel.ru.resx

            int i = 0;

            while (true)
            {
                string levelNum = i.ToString("00");
                string level = "Level_" + levelNum;
                string levelBeltColor = "Level_" + levelNum + "_BeltColor";
                string levelDescription = "Level_" + levelNum + "_Description";

                if (localizer[level] == level)
                {
                    break;
                }

                modelBuilder.Entity<SkillLevel>().HasData(
                    new SkillLevel
                    {
                        Id = i + 1,
                        Level = localizer[level],
                        BeltColor = localizer[levelBeltColor],
                        Description = localizer[levelDescription]
                    }
                );

                i++;
            }
        }
    }
}
