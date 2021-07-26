// Formatter

using CaT;
using System;
using System.Collections.Generic;
using static CaT.cat;

namespace Formatter
{
    using System.Linq;
    using System.Collections.Generic;

    public class Line_Breaks
    {
        public class General
        {
            //for General(Keep existing line breaks, Prefer wrap before ","﻿, Special "else if" treatment﻿,
            //Wrap long lines, Hard wrap at)

            int veryveryveryveryveryverylongnameofthefunction(
                int firstParameter,
                int secondParameter)
            {
                return checked(100000 * 10000) + unchecked(10000 * 10000);
            }

            void method(int firstParameter,
                        int secondParameter)
            {
            }

            void if_(int caseSwitch)
            {
                if (caseSwitch == 1 || caseSwitch < 8)
                {
                    int one = 1;
                }
                else if (caseSwitch == 0)
                {
                    int one = 0;
                }
                else
                {
                    int two = 2;
                }
            }
        }

        public class ArrangementOfAttributes
        {
            //for Line Breaks/Arrangement of attributes(Place attribute section list on separate line if it is longer than﻿,
            //Keep existing arrangement of attributes,Place type attribute on the same line﻿, Place method attribute on the same line﻿,
            //Place property/indexer/event attribute on the same line﻿, Place accessor attribute on the same line,
            //Place field attribute on the same line﻿)

            [Attr1, Attr2(true)]
            class C
            {
            }

            internal class Attr2Attribute : Attribute
            {
                private bool v;

                public Attr2Attribute(bool v)
                {
                    this.v = v;
                }
            }

            internal class Attr1Attribute : Attribute
            {
            }

            abstract class A
            {
                extern int Method1(
                    [System.Diagnostics.CodeAnalysis.NotNull] [ItemNotNull]
                    IList<string> items);
            }

            internal class ItemNotNullAttribute : Attribute
            {
            }

            interface I
            {
                [Attr1]
                void foo();

                int Property1
                {
                    [Attr1]
                    get;
                }
            }

            interface I1
            {
                [Attr1]
                int Property { get; }
            }

            class D
            {
                [Attr1]
                int n;

                void foo()
                {
                    // comment
                }
            }
        }

        public class ArrangementOfMethodSignatures
        {
            //for Arrangement of method signatures(Wrap formal parameters, Max formal parameters on a single line﻿,
            //Keep existing arrangement of parenthesis in declaration, Prefer wrap before "(" in declaration,
            //Prefer wrap after "(" in declaration﻿, Prefer wrap before ")" in declaration)

            interface IA
            {
                void M(int p1, int p2);

                void SomeMethod(int p1,
                                int p2,
                                int p3,
                                int p4);
            }

            //*constructor initializer*
            public ArrangementOfMethodSignatures()
                : base()
            {
            }
        }

        public class ArrangementOfExpressionBodiedMembers
        {
            //for Arrangement of expression bodied members﻿(Keep existing arrangement of expression bodied members﻿,
            //Prefer wrap before "=>" followed by expressions, Place method expression body on the same line﻿,
            //Place property expression body on the same line, Place property accessor expression body on the same line )

            //*property expression*
            public int Foo =>
                0;

            public int // comment
                Foo1 =>
                1;

            public int Foo2 =>
                1 + // comment
                2;

            //*method expression*
            class A
            {
                public int Foo() =>
                    0;

                public int // comment
                    Foo1() =>
                    1;

                public int Foo2() =>
                    1 + // comment
                    2;
            }

            //*property accessor expression*
            class B
            {
                public int Foo
                {
                    get =>
                        0;
                }

                public int Foo1
                {
                    get =>
                        1 + // comment
                        2;
                }
            }
        }

        public class ArrangementOfTypeParametersConstraintsAndBaseTypes﻿
        {
            //for Arrangement of type parameters, constraints and base types﻿(Allow type constraints on the same line﻿,
            //Prefer wrap before first constraint,
            //Wrap multiple type parameter constraints﻿, Prefer wrap before type parameters opening angle,
            //Prefer wrap before ":", Wrap extends/implements list﻿)

            //*type constraint*
            class C<T>
                where T : I1
            {
            }

            //*wrap before first constraint, multiple type parameter constraints*
            class C<T1, T2, T3>
                where T1 : I1
                where T2 : new()
                where T3 : class
            {
            }

            //*type parameters opening angle*
            class C<Type1, Type2,
                Type3, Type4>
            {
            }

            //*wrap extend list*
            class Derived
                : C,
                    I5,
                    I4,
                    I3
            {
            }
        }

        public class ArrangementOfDeclarationBlocks
        {
            //for Line Breaks \ Arrangement of declaration blocks(Keep existing arrangement of declaration blocks,
            //Place abstract/auto property/indexer/event declaration on single line﻿, Place simple property/indexer/event declaration on single line,
            //Place simple accessor on single line, Place it on single line even when it has attributes on accessors,
            //Place simple method on single line﻿)

            interface I7
            {
                int Property
                {
                    get;
                    set;
                }
            }

            interface I
            {
                int Property { get; set; }
            }

            class C
            {
                private int x = 5;

                int Property { get { return x; } set { x = value; } }
            }

            class R
            {
                void Foo()
                {
                    int y = 5;
                }

                int x;

                int Property
                {
                    [Attr]
                    get { return x; }
                    [Attr]
                    set { x = value; }
                }
            }

            //*simple method*
            class B
            {
                void Foo()
                {
                    Foo();
                }
            }
        }

        public class ArrangementOfEnumerations﻿
        {
            //for Arrangement of enumerations﻿(Keep existing arrangement of enumeration﻿,
            //Max enumeration members on a single line, Place simple enumeration on single line
            //Wrap enumeration declaration﻿)

            public enum Enum1
            {
                a,
                b,
                c
            }

            public enum Enum2
            {
                a,
                b,
                c
            }

            public enum Enum3
            {
                a,
                b,
                c,
                d
            }

            public enum Enum4
            {
                a,
                b,
                c
            }
        }

        public class ArrangementOfStatements﻿
        {
            //for Arrangement of statements﻿ (Place "while" on new line, Wrap "for" statement header﻿,
            //Wrap multiple declaration﻿)

            private int var1 = 1;

            void func()
            {
                //*FOR*
                for (int i = 0;
                    i < 10;
                    i++)
                {
                    int x = 2;
                }

                //*DO*
                do
                {
                    var1++;
                }
                while (1 > 2 && var1 < 10);
            }

            //*multiple declaration*
            public string name = "A",
                age = "B";
        }

        public class ArrangementOfEmbeddedStatements
        {
            //for Arrangement of embedded statements﻿(Keep existing arrangement of embedded statements﻿,
            //Place simple embedded statement on the same line﻿, Place simple "case" statement on the same line)

            private int var1 = 0;
            private int var2 = 0;
            private int foo;

            //*embedded statements*
            void func()
            {
                if (var1 == 0) var2 = 10;
                if (var1 == 0)
                    var2 = 1;
            }

            //*case*
            int func1()
            {
                switch (foo)
                {
                    case 1: return 0;
                    case 2:
                    case 3:
                        return 0;
                }

                return 0;
            }
        }

        public class ArrangementOfEmbeddedBlocks
        {
            //for Arrangement of embedded blocks(Keep existing arrangement of embedded blocks﻿,
            //Place a block with a single simple statement on the same line﻿, Place simple anonymous method on single line﻿)

            int var1 = 1;
            int var2 = 0;

            //*embedded blocks*
            void func()
            {
                if (var1 == 0)
                {
                    var2 = 10;
                }

                if (var1 == 0)
                {
                    var2 = 1;
                }
            }

            //* simple anonymous method*
            EventHandler e = delegate { return; };
        }

        public class ArrangementOfSwitchExpressions
        {
            //for Arrangement of switch expressions(Keep existing arrangement of switch expressions﻿,
            //Place simple switch expression on single line, Wrap switch expression)

            private static int var1 = 1;

            //*switch expressions*
            object result = var1 switch
            {
                1 => 0,
                0 => 1
            };
        }

        public class ArrangementOPropertyPatterns﻿
        {
            //for Arrangement of property patterns﻿(Keep existing arrangement of property patterns,
            //Place simple property pattern on single line﻿, Wrap property pattern)

            private static MyType sourceObject; //comment

            bool matches = sourceObject is MyType
                {
                    F1: 1,
                    F2: 2
                } &&
                sourceObject is MyType { F1: 1, F2: 2 };
        }

        public class ArrangementOfInitializers﻿
        {
            private object val1;
            private object val2;
            private object val3;
            private object val4;
            private object val5;
            private object val6;
            private object val7;
            private object val8;
            private object val9;

            //for Arrangement of initializers﻿(Keep existing arrangement of initializers﻿,
            //Place simple array, object and collection on single line, Wrap object and collection initializer,
            //Max object and collection initializer elements on a single line, Max array initializer elements on a single line
            //Wrap array initializer﻿)

            void func()
            {
                var result1 = new
                              {
                                  A = 0
                              };
                var result2 = new { A = 0 };
            }

            //*max object*
            void func2()
            {
                object x;

                x = new C() { Prop1 = 1 };
                x = new C() { Prop1 = 1, Prop2 = 1 };
                x = new C() { Prop1 = 1, Prop2 = 1, Prop3 = 1 };
                x = new C() { Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1 };
                x = new C()
                    {
                        Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                        Prop5 = 1
                    };
                x = new C()
                    {
                        Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                        Prop5 = 1, Prop6 = 1
                    };
                x = new C()
                    {
                        Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                        Prop5 = 1, Prop6 = 1, Prop7 = 1
                    };
                x = new C()
                    {
                        Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                        Prop5 = 1, Prop6 = 1, Prop7 = 1, Prop8 = 1
                    };
                x = new C()
                    {
                        Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                        Prop5 = 1, Prop6 = 1, Prop7 = 1, Prop8 = 1,
                        Prop9 = 1
                    };
            }

            //*array initializer*
            void func3()
            {
                object x;

                x = new[] { val1 };
                x = new[] { val1, val2 };
                x = new[] { val1, val2, val3 };
                x = new[] { val1, val2, val3, val4 };
                x = new[] { val1, val2, val3, val4, val5 };
                x = new[] { val1, val2, val3, val4, val5, val6 };
                x = new[] { val1, val2, val3, val4, val5, val6, val7 };
                x = new[] { val1, val2, val3, val4, val5, val6, val7, val8 };
                x = new[]
                    {
                        val1, val2, val3, val4, val5, val6, val7, val8,
                        val9
                    };
            }
        }

        public class ArrangementOfInvocations﻿
        {
            //in the Program.cs file
        }

        public class ArrangementOfMemberAccessExpressions
        {
            //Arrangement of member access expressions(Prefer wrap after "."﻿, Wrap chained method calls)
            object order = new Order()
                .AddCustomerDetails("Customer 1")
                .AddItem("ABCD", 10)
                .AddItem("PQRS", 20)
                .AddShippingDetails("address", "city", "postalcode")
                .Process();
        }

        public class ArrangementOfBinaryExpressions
        {
            //for Arrangement of binary expressions(﻿﻿Prefer wrap before operator in binary expression,
            //Force chop compound condition in "if" statement,
            //Force chop compound condition in "while" statement, Force chop compound condition in "do" statement)

            private int var1 = 1;
            private int var2 = 0;

            void func()
            {
                //*if*
                if (var1 == 0 && var2 < 4)
                {
                    var2 = 10;
                }

                if (var1 == 0 && var2 > 3)
                {
                    var2 = 1;
                }

                //*while*
                while (1 > 2 && var1 < 10) 
                {
                    var2++;
                }

                //*do*
                do
                {
                    var1++;
                }
                while (1 > 2 && var1 < 10);
            }
        }

        public class ArrangementOfTernaryExpressions
        {
            //for Arrangement of ternary expressions(Prefer wrap before "?" and ":" in ternary expressions,
            //Wrap ternary expression)

            //*ternary expressions*
            int x1 = true ? 1 : 0;

            public static object a;
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

            // Nested ternary expression style in the Program.cs file
        }

        public class ArrangementOfLINQExpressions
        {
            //for Arrangement of LINQ expressions(Wrap LINQ expressions, Place "into" on new line in LINQ expressions)

            static int[] array = 
                new int
                [] 
                {
                    1, 2, 3
                };

            object q = from x in array //*LINQ*
                where x != null
                select x;

            object q1 = from i in array
                select i
                into j
                where j != 0
                select j;
        }
    }

    public class ArrangementOfInterpolatedStrings
    {
        //for Arrangement of interpolated strings(Wrap verbatim interpolated strings﻿)
        private static object var1;
        private static object x;
        private static object y;

        object s = $@"id={var1} src={x
        } dest={y}";
    }

    internal class AttrAttribute : Attribute
    {
    }

    internal class C
    {
        public int Prop1 { get; internal set; }

        public int Prop2 { get; internal set; }

        public int Prop3 { get; internal set; }

        public int Prop4 { get; internal set; }

        public int Prop5 { get; internal set; }

        public int Prop6 { get; internal set; }

        public int Prop7 { get; internal set; }

        public int Prop8 { get; internal set; }

        public int Prop9 { get; internal set; }
    }

    internal class Attr1Attribute : Attribute
    {
    }

    internal interface I3
    {
    }

    internal interface I4
    {
    }

    internal interface I5
    {
    }
}

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
    }
}
