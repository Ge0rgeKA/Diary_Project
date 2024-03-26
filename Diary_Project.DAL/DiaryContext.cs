using Diary_Project.COMMON.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Класс для работы с БД
namespace Diary_Project.DAL
{
    public class DiaryContext : DbContext
    {
        public DbSet<UserDb> Users { get; set; }
        public DiaryContext(DbContextOptions<DiaryContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
