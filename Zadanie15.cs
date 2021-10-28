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
            
            ISeries series = new GeomProgression();
            series.setStart(8);
            series.getNext();
            series.reset();

            ISeries series2 = new ArithProgression();
            series2.setStart(7);
            series2.getNext();
            series2.reset();

        }

    }

      interface ISeries
    {
        void setStart(int x);                                                //устанавливает начальное значение
        int getNext();                                                     //возвращает следующее число ряда
        void reset();                                                        //выполняет сброс к начальному значению
    }

    class GeomProgression : ISeries
    {
        int start = 1;
        int val = 0;
        int progrkoeff = 1;


        public int getNext(int progrkoeff = 5)

        {
            this.progrkoeff = progrkoeff;
            val = val * progrkoeff;
            return val;
        }

        public int getNext()
        {
            this.progrkoeff = progrkoeff;
            val = val * progrkoeff;
            return val;
        }

        public void reset()
        {
            val = start;
            return;
        }

        public void setStart(int x, int progrkoeff)
        {
            start = x;
            val = x;
            return;

        }



        public void setStart(int x)
        {
            return;
        }
    }
        class ArithProgression : ISeries
        {
            int start = 0;
            int val = 0;
            int progrkoeff = 1;

            public int getNext(int progrkoeff)
            {
                
                val = val + progrkoeff;
                return val;
            }

            public int getNext()
            {
                return val;
            }

            public void reset()
            {
                
                val = start;
                return;
            }

            public void setStart(int x, int progrkoeff)
            {
                start = x;
                val = x;
                return;

            }

            public void setStart()
            {
                return;
            }

            public void setStart(int x)
            {
                return;
            }
        }
    }
