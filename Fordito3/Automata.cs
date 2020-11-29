using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Fordito3
{
    class Automata
    {
        string input;
        int i;

        public string simple(string st)
        {
            return Regex.Replace(st,"([0-9]{1,2})+","i");
        }
        public void elfogad(char ch)
        {
            if (input[i] != ch)
            {
                Console.WriteLine("Hibás kifejetés {0}. Helyes karakter: {1}",input,input[i]);
            }
            i++;
        }

        public Automata(string input)
        {
            Console.WriteLine("Eredeti input: {0}", input);
            this.input = $"{simple(input)}#";
            Console.WriteLine("Az egyszerűsített input: {0}", this.input);
        }

        public void S()
        {
            E();
            elfogad('#');
            Console.WriteLine("Az elemzés lefutott");
        }
        void E()
        {
            T();
            Ev();
        }
        void T()
        {
            F();
            Tv();
        }
        void Ev()
        {
            if (input[i] == '+')
            {
                elfogad('+');
                T();
                Ev();
            }
        }
        void Tv()
        {
            if (input[i]=='*')
            {
                elfogad('*');
                F();
                Tv();
            }
        }

        void F()
        {
            if (input[i] == '(')
            {
                elfogad('(');
                E();
                elfogad(')');
            }
            else
            {
                elfogad('i');
            }
        }
    }
}
