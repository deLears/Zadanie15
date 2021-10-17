using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Zadanie15
    {
        static void Main(string[] args)
        {
        }

    }

    internal interface ISeries
    {
        void setStart(int x);                                                //устанавливает начальное значение
        int getNext();                                                     //возвращает следующее число ряда
        void reset();                                                        //выполняет сброс к начальному значению
    }

    class GeomProgression : ISeries
    {
        int start = 0;
        int val = 0;
        int progrkoeff = 1;

        public int getNext(int progrkoeff)
        {
            throw new NotImplementedException();

            val = val * progrkoeff;
            return val;
        }

        public void reset()
        {
            throw new NotImplementedException();
            val = start;
            return;
        }

        public void setStart(int x, int progrkoeff)
        {
            throw new NotImplementedException();
            start = x;
            val = x;
            return;

        }

        class ArithProgression : ISeries
        {
            int start = 0;
            int val = 0;
            int progrkoeff = 1;

            public int getNext(int progrkoeff)
            {
                throw new NotImplementedException();

                val = val + progrkoeff;
                return val;
            }

            public void reset()
            {
                throw new NotImplementedException();
                val = start;
                return;
            }

            public void setStart(int x, int progrkoeff)
            {
                throw new NotImplementedException();
                start = x;
                val = x;
                return;

            }

        }
    }
}
