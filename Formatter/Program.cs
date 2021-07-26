using System;
using static CaT.cat;
namespace Formatter
{
    class Program
    {
        // Comments like "//for Braces Layout(Indent inside namespace declaration)" mean,
        // that in the following part of a code, the setting of parameter "Indent inside namespace declaration"
        // can be tested.
        // Comments like "//*field*" have created for quick navigation.
        // In the Google document https://docs.google.com/document/d/1yBhHN_Erm-J7xBFGa-1mBx7mwxLaQ_fVVFfurJW-Iaw/edit#
        // the parameters, that have already been added in the code, are highlighted in blue.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            {
                //for Tabs, Indents, Alignment/Other Indents(Outdent statement labels﻿)

                //*label(tabs)*
                int a = 5;
                MyLabel:
                a--;
                if (a > 0) goto MyLabel;
            }

            //for Line Breaks/Arrangement of invocations﻿(Wrap invocation arguments﻿, Max invocation arguments on a single line﻿,
            //Keep existing arrangement of parenthesis in invocation, Prefer wrap before "(" in invocation, Prefer wrap after "(" in invocation,
            //Prefer wrap before ")" in invocation)

            //*invocations*
            Cat cat = new Cat { Age = 10, Name = "Fluffy" };
            cat.FeedCat("Cat");
            cat.CallCat(1,
                2,
                3);

            //for Line Breaks \ Arrangement of ternary expressions(Nested ternary expression style)
            //Nested ternary expression style
            a = i ? "am" : you ? "are" : "is";

            b = error ? red :
                warning ? yellow :
                green;

            c = tiger
                ? dangerous
                : dog
                    ? cute
                    : boring;
        }

        GenericList<float> list1 = new GenericList<float>();
        private static object a;
        private static object b;
        private static object c;
        private static bool i;
        private static bool you;
        private static bool error;
        private static object red;
        private static bool warning;
        private static object yellow;
        private static object green;
        private static bool tiger;
        private static object dangerous;
        private static bool dog;
        private static object cute;
        private static object boring;
    }

    internal class GenericList<T>
    {
    }
}
