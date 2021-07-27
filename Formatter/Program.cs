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
        // In the Google document https://docs.google.com/document/d/13Yrg8_23Dn1ogNF_GFQbkvctFEP9-DKbBRwcZZFMpxY/edit#
        // the parameters, that have already been added in the code, are highlighted in blue.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            {
                //TODO Tabs, Indents, Alignment/Other Indents(Outdent statement labels﻿)
                //for Tabs, Indents, Alignment/Other Indents(Outdent statement labels﻿)

                //*label(tabs)*
                int a = 5;
                MyLabel:
                a--;
                if (a > 0) goto MyLabel;
            }

            //TODO Line Breaks/Arrangement of invocations﻿
            //for Line Breaks/Arrangement of invocations﻿(Wrap invocation arguments﻿, Max invocation arguments on a single line﻿,
            //Keep existing arrangement of parenthesis in invocation, Prefer wrap before "(" in invocation, Prefer wrap after "(" in invocation,
            //Prefer wrap before ")" in invocation)

            //*invocations*
            Cat cat = new Cat { Age = 10, Name = "Fluffy" };
            cat.FeedCat("Cat");
            cat.CallCat(1,
                2,
                3);

            //TODO Line Breaks \ Arrangement of ternary expressions
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

//TODO Spaces \Around braces
//for Spaces \Around braces (Before single line accessors block, Within single line accessors, Between accessors in single line property/event,
//Space between empty braces, Within single line method, Within single line anonymous method, Within single-line expression braces)
namespace CaT
{
    class cat
    {
        public class Cat
        {
            public int Age { get; set; }

            public string Name { get; set; }

            public Cat()
            {
            }

            public Cat(string name)
            {
                this.Name = name;
            }

            public void FeedCat(string name)
            {
                int a = 1;
            }

            public void CallCat(int a, int b, int c)
            {
                int d = a + b + c;
            }
        }

        EventHandler e = delegate { return; };

        Cat anothercat = new Cat { Age = 10, Name = "Fluffy" };

        Cat sameCat = new Cat("Fluffy") { Age = 10 };
    }
}
