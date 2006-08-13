using System;
using System.Text;

namespace JMathToolkit.Core
{
    public class Scanner
    {

        public static void ParseString(String Input)
            /* Version 0.1
             * Die Methode parst einen String s, welcher einen Input in das Program darstellt.
             * Dieser Input besteht aus einer der beiden Operationen Addition und Subtraktion sowie Zahlen.
             */
        {
            if (Input == null) throw new Exceptions.NullStringException();
            if (Input.Equals("")) throw new Exceptions.EmptyStringException();
            if (Input.Contains(" ")) throw new Exceptions.StringContainsSpaceException();
        }

    }
}
