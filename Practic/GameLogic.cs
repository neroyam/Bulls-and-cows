using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic
{

   
    public class Generation//генерация строки
    {
        public List<int> code = new List<int>();
        Random rand = new Random();
        public List<int> SetCode()
        {

            int r = 0;
            bool same = true;
            for (int i = 0; i < 4; i++)
            {
                while (same)
                {
                    r = rand.Next(0, 9);
                    if (!code.Contains(r)) { same = false; }
                }
                code.Add(r);
                same = true;

            }
            return code;
        }
    }
    public enum GameStat //перечисление игрового статуса
    {
        Active = 1,
        Win = 2,
        Lose = 3
    }

    public class Board  //инициализация игрового поля и всех вспомогательных элементов
    {
        public List<int> Rows = new List<int>() ;
        public List<int> Code = new List<int>();

        public List<int> Res = new List<int>() { 0, 0 };
      //  public Code Code = new Code();
        public GameStat status = new GameStat();

     
        public void Check(List<int>Rows, List<int> Code) //проверка полученной комбинации от пользователя
        {
            for (int i = 0; i < 4; i++)
            {
                if (Rows[i] == Code[i]) Res[0]++;
                if (Code.Contains(Rows[i]) && Rows[i] != Code[i]) Res[1]++;
            }
          
            if (Res[0] == 4) status = GameStat.Win;         
        }
       public void Zero() //обнуление результативной строки
        {
            Res[0] = 0;
            Res[1] = 0;
        }
        public bool FullStroke()  //проверка на целостность строки
        {
            if (Code.Contains(-1)) return false;
            return true;
        }
        

    }


}
