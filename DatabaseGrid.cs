using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourElements
{
    // Таблица для комнат
    class DatabaseGrid_Rooms
    {
        public int NumOfOccups { get; set; }

    }

    // Таблица для данных о продаже продуктов
    class Database_Food
    {
        public int Food { get; set; }
        public int Wine { get; set; }
        public int Soft { get; set; }
        public int Beer { get; set; }
        public int Spirits { get; set; }
        public int Others { get; set; }
    }
}
