using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class User
    {
        // EF Core 預設會解譯名為 ID 或 classnameID 作為主索引鍵的屬性
        // 這邊的話就會是 Id 或 UserID
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
