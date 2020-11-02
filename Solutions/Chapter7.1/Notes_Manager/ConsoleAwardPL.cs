using Notes.BLL.Common;
using Notes.BLL.Dependencies;
using Notes.Entites;
using Notes.PL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Manager
{
   
        public class ConsoleAwardPL : IAwardPL
        {

            private IAwardBLL _bll;

            public ConsoleAwardPL()
            {
                _bll = NotesBLLDependencies.AwardBLL;
            }
            public bool AddAward()
            {
                Console.WriteLine("Добавление новой награды..." + Environment.NewLine);
                Console.Write("Введите название:");
                string title = Console.ReadLine();

                return _bll.SaveAward(new Award(title));

            }

            public bool DeleteAward()
            {
                Console.WriteLine("Удаление награды..." + Environment.NewLine);
                Guid id = SelectedAward();
                return _bll.DeleteAward(id);
            }

            public void DisplayAllAwards()
            {
                var users = _bll.GetAllAwards();

                Console.WriteLine("Сохраненные награды:" + Environment.NewLine);

                foreach (Award item in users)
                {
                    Console.WriteLine(string.Format("Название: {0}",
                         item.Title));
                }
            }

            public Guid SelectedAward()
            {
                Dictionary<int, Guid> ID = new Dictionary<int, Guid>();
                var awards = _bll.GetAllAwards();

                Console.WriteLine("Выберите награду:" + Environment.NewLine);
                int serialNumber = 1;

                foreach (Award item in awards)
                {
                    Console.WriteLine(string.Format("Награда №{0}. Название: {1}",
                        serialNumber, item.Title));
                    ID.Add(serialNumber, item.ID);
                    serialNumber++;
                }

                if (int.TryParse(Console.ReadLine(), out int number) && number > 0 && number < serialNumber)
                {
                    return ID[number];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("number");
                }

            }
        }
}
