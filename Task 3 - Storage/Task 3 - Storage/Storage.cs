using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_3___Storage
{
    //Базовый класс(«Storage») содержит следующие закрытые
    //поля:
    //■ наименование носителя;
    //■ модель.
    //Класс обладает всеми необходимыми свойствами для
    //доступа к полям, а также абстрактными методами:
    //■ получение объема памяти;
    //■ копирование данных(файлов/папок) на устройство,
    //■ получение информации о свободном объеме памяти
    //на устройстве;
    //■ получение общей/полной информации об устройстве.
    class Storage : Folder
    {
        public string Model { get; protected set; }
        public int Speed { get; protected set; }
        public int Memory { get; protected set; }
      
        public int FreeMemory()
        {
            return Memory - Capacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name}-{Model} ({Speed}Mb/s) - {Capacity} Mb/{Memory} Mb");
        }
    }
}
