using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    // 繼承 DbContext
    public class DataContext : DbContext
    {
        // 建構子參數 DbContextOptions<T> 並傳入父類別
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        // 一般習慣在 Model 命名使用單數，這邊資料表命名使用複數
        public DbSet<User> Users { get; set; }
    }
}
