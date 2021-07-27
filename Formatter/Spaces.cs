// Formatter

using Formatter;

namespace Formatter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Spaces
    {
        //TODO Spaces/Preserve existing formatting
        public class PreserveExistingFormatting
        {
            private static object foo(int v)
            {
                throw new NotImplementedException();
            }

            //for Preserve existing formatting(Extra spaces inside)
            
            object x = foo(5);
            object xx = foo(5 + 6);
            object xxx = foo(5 + 6 + 7);
            object tab = foo(5);
            object tabx = foo(5 + 6);
            object tabxx = foo(5 + 6 + 7);
        }

        //TODO Spaces/Before parentheses in statements
        public class BeforeParenthesesInStatements﻿
        {
            // for Before parentheses in statements﻿("if" parentheses﻿, "while" parentheses﻿, "catch" parentheses, switch" parentheses﻿,
            // "for" parentheses﻿, using" parentheses﻿,
            //"foreach" parentheses, lock" parentheses, "fixed" parentheses﻿﻿)
            private int var1 = 1;
            private int var2 = 2;

            //*if*
            void if_()
            {
                if (var1 == 0 && var2 < 4)
                {
                    var2 = 10;
                }

                if (var1 == 0 && var2 > 3)
                {
                    var2 = 1;
                }
            }

            //*while*
            void while_()
            {
                while (1 > 2 && var1 < 10)
                {
                    var2++;
                }
            }

            //*CATCH*
            void catch_()
            {
                try
                {
                    foo();
                    foo2(var1, var2);
                }
                catch (Exception)
                {
                }
            }

            //*switch*
            int switch_()
            {
                switch (var1)
                {
                    case 1: return 0;
                    case 2:
                    case 3:
                        return 0;
                }

                return 0;
            }

            //*for*
            void for_()
            {
                for (int i = 0;
                    i < 10;
                    i++)
                {
                    var1 = 2;
                }
            }

            //*FOREACH*
            void foreach_()
            {
                foreach (object o in array)
                {
                    foo();
                }
            }

            //*LOCK*
            void lock_()
            {
                lock (array)
                {
                    foo();
                }
            }

            //*fixed*
            public unsafe virtual void F(int x)

            {
                int* ptr = &x;
                int* ptr2 = &x;
                fixed (int* fib = new int[1])
                {
                    int b = 5;
                }
            }

            //*using*
            public class C<T>
                where T : IDisposable
            {
                public void F(T t)
                {
                    using (t)
                    {
                    }
                }
            }

            static int[] array =
                new int
                []
                {
                    1, 2, 3
                };

            private void foo2(int var1, int var2)
            {
                int var3 = var1 + var2;
            }

            private void foo()
            {
            }
        }

        //TODO Spaces/Before other parentheses
        public class BeforeOtherParentheses
        {
            //for Before other parentheses(Method call parentheses﻿, Method call empty parentheses﻿,  Method declaration parentheses﻿,
            //Method declaration empty parentheses, "typeof" parentheses﻿, "default" parentheses﻿, checked" and "unchecked" parentheses﻿,
            //"sizeof" parentheses, "nameof" parentheses, "new" parentheses, Between keyword and expression﻿, Between keyword and type﻿ )

            //*default*
            int foo()
            {
                return default(int);
            }

            //*NAMEOF*
            string foo2(object myField)
            {
                return nameof(myField);
            }

            //*TYPEOF*
            Type t = typeof(bool);

            //*SIZEOF*
            int size = sizeof(bool);

            //*NEW* 
            List<int> T = new();

            //*CHECKED & UNCHECKED*
            int fooC(int firstParameter,
                     int secondParameter)
            {
                return checked(100000 * 10000) + unchecked(10000 * 10000);
            }

            //*method calls*
            void call_(int firstParameter,
                       int secondParameter)
            {
                fooC(firstParameter,
                    secondParameter);
                foo();
            }

            //*between keyword*
            public SomeType A(object a)
            {
                return (SomeType)a ?? throw (new Exception());
            }

            public (int, int) A(ref (int, int) a)
            {
                return a;
            }
        }

        //TODO Spaces/Within parentheses in statements
        public class WithinParenthesesInStatements
        {
            //for Within parentheses in statements("if" parentheses﻿, "while" parentheses﻿, "catch" parentheses, switch" parentheses﻿,
            // "for" parentheses﻿, using" parentheses﻿,
            //"foreach" parentheses, lock" parentheses, "fixed" parentheses)
            private int var1 = 1;
            private int var2 = 2;

            //*if*
            void if_()
            {
                if (var1 == 0 && var2 < 4)
                {
                    var2 = 10;
                }

                if (var1 == 0 && var2 > 3)
                {
                    var2 = 1;
                }
            }

            //*while*
            void while_()
            {
                while (1 > 2 && var1 < 10)
                {
                    var2++;
                }
            }

            //*CATCH*
            void catch_()
            {
                try
                {
                    foo();
                    foo2(var1, var2);
                }
                catch (Exception)
                {
                }
            }

            //*switch*
            int switch_()
            {
                switch (var1)
                {
                    case 1: return 0;
                    case 2:
                    case 3:
                        return 0;
                }

                return 0;
            }

            //*for*
            void for_()
            {
                for (int i = 0;
                    i < 10;
                    i++)
                {
                    var1 = 2;
                }
            }

            //*FOREACH*
            void foreach_()
            {
                foreach (object o in array)
                {
                    foo();
                }
            }

            //*LOCK*
            void lock_()
            {
                lock (array)
                {
                    foo();
                }
            }

            //*fixed*
            public unsafe virtual void F(int x)

            {
                int* ptr = &x;
                int* ptr2 = &x;
                fixed (int* fib = new int[1])
                {
                    int b = 5;
                }
            }

            //*using*
            public class C<T>
                where T : IDisposable
            {
                public void F(T t)
                {
                    using (t)
                    {
                    }
                }
            }

            static int[] array =
                new int
                []
                {
                    1, 2, 3
                };

            private void foo2(int var1, int var2)
            {
                int var3 = var1 + var2;
            }

            private void foo()
            {
            }
        }

        //TODO Spaces/Withing Other Parentheses
        public class WithinOtherParentheses
        {
            //for Withing Other Parentheses(Parentheses﻿, Type cast parentheses, Method call parentheses﻿,
            //Method call empty parentheses﻿,  Method declaration parentheses﻿,
            //Method declaration empty parentheses,"typeof" parentheses﻿,
            //"default" parentheses﻿, checked" and "unchecked" parentheses﻿,
            //"sizeof" parentheses, "nameof" parentheses, "new" parentheses)

            //*default*
            int foo()
            {
                return default(int);
            }

            //*NAMEOF*
            string foo2(object myField)
            {
                return nameof(myField);
            }

            //*TYPEOF*
            Type t = typeof(bool);

            //*SIZEOF*
            int size = sizeof(bool);

            //*NEW* 
            List<int> T = new(5);

            //*CHECKED & UNCHECKED*
            int fooC(int firstParameter,
                     int secondParameter)
            {
                return checked(100000 * 10000) + unchecked(10000 * 10000);
            }

            //*method calls*
            void call_(int firstParameter,
                       int secondParameter)
            {
                fooC(firstParameter,
                    secondParameter);
                foo();
            }

            //*between keyword*
            public SomeType A(object a)
            {
                return (SomeType)a ?? throw (new Exception());
            }

            public (int, int) A(ref (int, int) a)
            {
                return a;
            }
        }

        //TODO Spaces/Around array brackets
        public class AroundArrayBrackets
        {
            //for Around array brackets(Before array access brackets﻿, Before array rank brackets, Within array access brackets,
            //Within array rank brackets, Within array rank empty brackets﻿)

            static int[] array =
                new int
                []
                {
                    1, 2, 3
                };

            void func_()
            {
                for (int i = 0; i < 5; i++)
                {
                    array[i] = array[i + 1];
                }

                int[][,] x = null;
            }
        }

        //TODO Spaces/Around angle brackets
        public class AroundAngleBrackets
        {
            //for Around angle brackets﻿(Before type parameter list angle, Before type argument list angle﻿, Type parameter angles
            //Type argument angles)

            class C1<T1,
                T2,
                T3>
                where T1 : I1
                where T2 : I2
            {
            }

            GenericList<float> list1 = new GenericList<float>();
        }

        public class AroundBraces
        {
            //in the Program.cs file
        }

        //TODO Spaces/Around binary operators
        public class AroundBinaryOperators
        {
            // for Around binary operators(Assignment operators (=,+=,...)﻿, Logical operators(&&,||), Equality operators(==,!=),
            //Relational operators(<,>,<=,>=) ,Bitwise operators(&,|,^),Additive operators(+,-) ,Multiplicative operators(*,/,%),
            //Shift operators(<<,>>) ,Null coalescing operator (??), Unsafe arrow operator (->)﻿ )

            class Spaces : Class1
            {
                void binary_unary_spaces()
                {
                    bool a = true;
                    bool b = false;
                    int c = +1;
                    int d = -2;
                    int? x = 5;

                    if (a && b || c == d || c < d)
                    {
                        c += 1;
                        c = d ^ c + d / c << 1;
                        x = x ?? x;
                        c++;
                        --c;
                    }

                    if (!a) return;

                    bool expr = true;
                    static int Switch_exp(bool expr)
                    {
                        switch (expr)
                        {
                            case true: return 1;
                            case false: return 0;
                        }
                    }
                }

                class C1<T1,
                    T2,
                    T3>
                    where T1 : I1
                    where T2 : I2
                {
                }

                [return: Description("returns A")]
                public Spaces b()
                {
                    Method1(arg1: 1, arg2: 3);
                    var y = (tuple1: 1, tuple2: 2);
                    return null;
                }

                private void Method1(int arg1, int arg2)
                {
                    int arg3 = arg1 + arg2;
                }
            }

            public struct Coords
            {
                public int X;
                public int Y;

                public override string ToString() => $"({X}, {Y})";
            }

            public class PointerMemberAccessExample
            {
                public static unsafe void F1()
                {
                    Coords coords;
                    Coords* p = &coords;
                    Coords p1 = *p;
                    p->X = 3;
                    p->Y = 4;
                    Console.WriteLine(p->ToString()); // output: (3, 4)
                }
            }
        }

        //TODO Spaces/Around unary operators
        public class AroundUnaryOperators
        {
            //for Around unary operators(Logical not operator (!)﻿, Unary minus operator (-), Unary plus operator (+),
            //Unsafe addressof operator (&)﻿, Unsafe asterisk operator (*), Before/after ++ and --﻿)
            class Spaces : Class1
            {
                void binary_unary_spaces()
                {
                    bool a = true;
                    bool b = false;
                    int c = +1;
                    int d = -2;
                    int? x = 5;

                    if (a && b || c == d || c < d)
                    {
                        c += 1;
                        c = d ^ c + d / c << 1;
                        x = x ?? x;
                        c++;
                        --c;
                    }

                    if (!a) return;

                    bool expr = true;
                    static int Switch_exp(bool expr)
                    {
                        switch (expr)
                        {
                            case true: return 1;
                            case false: return 0;
                        }
                    }
                }

                public struct Coords
                {
                    public int X;
                    public int Y;

                    public override string ToString() => $"({X}, {Y})";
                }

                public class PointerMemberAccessExample
                {
                    public static unsafe void F1()
                    {
                        Coords coords;
                        Coords* p = &coords;
                        Coords p1 = *p;
                        p->X = 3;
                        p->Y = 4;
                        Console.WriteLine(p->ToString()); // output: (3, 4)
                    }
                }

                [return: Description("returns A")]
                public Spaces b()
                {
                    Method1(arg1: 1, arg2: 3);
                    var y = (tuple1: 1, tuple2: 2);
                    return null;
                }

                private void Method1(int arg1, int arg2)
                {
                    int arg3 = arg1 + arg2;
                }
            }
        }

        //TODO Spaces/In ternary operator
        public class InTernaryOperator
        {
            //for In ternary operator(Before '?'﻿,After '?',Before ':',After ':' )

            //*ternary expressions*
            int x1 = true ? 1 : 0;
        }

        //TODO Spaces/Around comma and semicolon
        public class AroundCommaAndSemicolon
        {
            // for Around comma and semicolon(Before comma, After comma, Before semicolon, Before "for" semicolon,
            // After "for" semicolon)

            [return: Description("returns A")]
            public Spaces b()
            {
                Method1(arg1: 1, arg2: 3);
                var y = (tuple1: 1, tuple2: 2);
                return null;
            }

            void for_()
            {
                for (int i = 1; i < 10; i++)
                {
                    i++;
                }
            }
           


            private void Method1(int arg1, int arg2)
            {
                int arg3 = arg1 + arg2;
            }
        }

        //TODO Spaces/Around colon
        public class AroundColon
        {
            //for Around colon(Before base types list colon, After base types list colon﻿, Before type parameter constraint colon,
            //After type parameter constraint colon﻿, Before colon in “case” statement, After colon in “case” statement ,
            //Before other colons, After other colons﻿)

            class Spaces : Class1
            {
                void binary_unary_spaces()
                {
                    bool a = true;
                    bool b = false;
                    int c = +1;
                    int d = -2;
                    int? x = 5;

                    if (a && b || c == d || c < d)
                    {
                        c += 1;
                        c = d ^ c + d / c << 1;
                        x = x ?? x;
                        c++;
                        --c;
                    }

                    if (!a) return;

                    bool expr = true;
                    static int Switch_exp(bool expr)
                    {
                        switch (expr)
                        {
                            case true: return 1;
                            case false: return 0;
                        }
                    }
                }

                class C1<T1,
                    T2,
                    T3>
                    where T1 : I1
                    where T2 : I2
                {
                }

                [return: Description("returns A")]
                public Spaces b()
                {
                    Method1(arg1: 1, arg2: 3);
                    var y = (tuple1: 1, tuple2: 2);
                    return null;
                }

                private void Method1(int arg1, int arg2)
                {
                    int arg3 = arg1 + arg2;
                }
            }
        }

        //TODO Spaces/Attributes
        public class Attributes
        {
            //for Attributes(Between attribute sections, Within attribute brackets, After attributes﻿)

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

        //TODO Spaces/Others
        public class Others
        {
            //for Others(Around dot, Around lambda arrow, Before unsafe pointer declaration,
            //Before nullable mark﻿, Before end of line comment﻿, After operator keyword﻿, After type cast parentheses
            //)

            private Func<object, object> c;

            //**
            private static double b = 10.5;
            int d = (int)b;

            public class PointerMemberAccessExample
            {
                public static unsafe void F1()
                {
                    AroundBinaryOperators.Coords coords;
                    AroundBinaryOperators.Coords* p = &coords;
                    AroundBinaryOperators.Coords p1 = *p;
                    p->X = 3;
                    p->Y = 4;
                    Console.WriteLine(p->ToString()); // output: (3, 4)
                }
            }

            internal class a
            {
                internal static void foo()
                {
                }
            }

            public void A()
            {
                a.foo();
                c = x => x;
                int? i = null;
            }

            //*After operator keyword*
            public readonly struct Fraction
            {
                private readonly int num;
                private readonly int den;

                public Fraction(int numerator, int denominator)
                {
                    if (denominator == 0)
                    {
                        throw new ArgumentException(
                            "Denominator cannot be zero.", nameof(denominator));
                    }

                    num = numerator;
                    den = denominator;
                }

                public static Fraction operator +(Fraction a) => a;

                public static Fraction operator -(Fraction a) =>
                    new Fraction(-a.num, a.den);

                public static Fraction operator +(Fraction a, Fraction b)
                    => new Fraction(a.num * b.den + b.num * a.den,
                        a.den * b.den);

                public static Fraction operator -(Fraction a, Fraction b)
                    => a + (-b);

                public static Fraction operator *(Fraction a, Fraction b)
                    => new Fraction(a.num * b.num, a.den * b.den);

                public static Fraction operator /(Fraction a, Fraction b)
                {
                    if (b.num == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    return new Fraction(a.num * b.den, a.den * b.num);
                }

                public override string ToString() => $"{num} / {den}";
            }
        }

        internal class Class1
        {
        }

        public class SomeType
        {
        }
    }
}

//for Others(Around '=' in namespace alias directive)

namespace W
{
    using X = A;

    class W1
    {
        private static MyType sourceObject; //comment

        bool matches = sourceObject is MyType
            {
                F1: 1,
                F2: 2
            } &&
            sourceObject is MyType { F1: 1, F2: 2 };
    }
}
