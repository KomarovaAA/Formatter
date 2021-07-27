// Formatter

namespace Formatter
{
    using System;
    using System.Linq;

    public class Tabs__Indents__Alignment
    {
        //TODO Tabs Indents Alignment/General
        class General
            //for General (Use indent style and size from Visual Studio, Indent style, Indent size,
            //Continuous line indent multiplier)
        {
            interface I
            {
                void foo();
            }

            class C
            {
            }

            //*continuous line indent multiplier*
            int foo(int firstParameter,
                    int secondParameter)
            {
                return checked(100000 * 10000) +
                    unchecked(10000 * 10000); //just a comment
            }
        }

        //TODO Tabs Indents Alignment/Parenthesis
        public class Parenthesis
        {
            //Parenthesis(Use continuous line indent inside parenthesis, Indent method declarations' parenthes,
            //Indent method calls' parenthesis, Indent statement (if, while, for, etc) parenthesis﻿, Indent type parameter's angles,
            //Indent type argument's angles﻿, Indent other parenthesis and brackets)

            abstract class A
            {
                static int var1 = 0;
                static int var2 = 1;

                int x = Method(
                    var1,
                    var2
                );

                private extern int Method1(
                    int parameter1,
                    int parameter
                );

                class C1<T1,
                    T2,
                    T3>
                    where T1 : I1
                    where T2 : I2
                {
                }

                static int Method(int parameter1, int parameter2)
                {
                    var y = Method<
                        General
                    >();

                    var x = 1 * checked(
                        5 +
                        6
                    );

                    if (
                        parameter1 == 0 && parameter2 == 1
                    )
                        return 0;
                    return 0;
                }

                private static object Method<T>()
                {
                    throw new NotImplementedException();
                }
            }
        }

        //TODO Tabs Indents Alignment/Preprocessor directives
        abstract class PreprocessorDirectives
        {
            //for Preprocessor directives﻿(Indent #region, #endregion, Indent #if, #else, #elif, #endif﻿, Indent other preprocessor directives)

            protected abstract void Method1();

            #region Region Description

            protected abstract void Method2();

            #endregion

            protected abstract void Method3();

            class C
            {
#if !HideSomething
                int myField;
#endif
            }

            class K
                : C,
                    Someinterface
            {
#pragma warning disable CS3021
                int myField;
#warning Fixme
            }
        }

        //TODO Tabs Indents Alignment/Other Indents
        public class OtherIndents
        {
            //for Other Indents(Indent "case" from "switch"﻿,Indent type constraints﻿ )
            void Function1()
            {
                int caseSwitch = 1;
                switch (caseSwitch)
                {
                    case 1:
                    {
                        int one = 1;
                        break;
                        int k = 5;
                    }
                    default:
                    {
                        int three = 3;
                        break;
                    }
                }
            }

            //*type constraints﻿*
            class C1<T1>
                where T1 : I1
            {
            }
        }

        //TODO Tabs Indents Alignment/Align Multiline constructs
        public class AlignMultilineConstructs
        {
            //for Align Multiline constructs(How to align when tabs are used for indents,
            //Align even if the resulting indentation is too large, Method parameters﻿, List of base classes and interfaces,
            //LINQ query, Chained binary expressions, Outdent binary operators, Chained method calls,
            //Outdent dots in chained method calls﻿, 
            //Array, object and collection initializer﻿, Switch expressions, Call arguments by '('﻿,
            //Call arguments, ﻿Property patterns﻿, Tuple components, Other expressions, "for" statement header
            //Type parameters list﻿, Type parameter constraints, Outdent commas)

            //*large indent after alignment and method*
            int veryveryveryveryveryverylongnameofthefunction(
                int firstParameter,
                int secondParameter)
            {
                return checked(100000 * 10000) + unchecked(10000 * 10000);
            }

            //*method parameters*
            void method(int firstParameter,
                        int secondParameter)
            {
            }

            //*list of base classes and interfaces*
            class C
            {
#if !HideSomething
                int myField;
#endif
            }

            class K
                : C,
                    Someinterface
            {
#pragma warning disable CS3021
                int myField;
#warning Fixme
            }

            //*LINQ*
            object q = from x in array
                where x != null
                select x;

            object q1 = from i in array
                select i
                into j
                where j != 0
                select j;

            //*binary expressions*
            static int someOperand = 0;

            object a = someOperand +
                caseSwitch +
                caseSwitch +
                caseSwitch;

            object b = someOperand
                + caseSwitch
                + caseSwitch
                + caseSwitch;

            //*switch expressions*
            private static int caseSwitch = 1;

            int z = caseSwitch switch
            {
                1 => 1,
                2 => 2,
                3 => 3,
            };

            //*property patterns*
            bool matches = sourceObject is MyType
            {
                Field1: 1,
                Field2: 2,
            };

            //*multiple declaration*
            public string name = "A",
                age = "B";

            //*array*
            static int[] array =
                new int
                []
                {
                    1, 2, 3
                };

            //chained method
            object order = new Order()
                .AddCustomerDetails("Customer 1")
                .AddItem("ABCD", 10)
                .AddItem("PQRS", 20)
                .AddShippingDetails("address", "city", "postalcode")
                .Process();

            //*call*
            void call_()
            {
                method(firstParameter,
                    secondParameter);
            }

            //*tuple, other*
            static int firstParameter = 1;
            static int secondParameter = 1;

            object tuple = (firstParameter,
                secondParameter);

            private static MyType sourceObject;

            //*for*
            void for_()
            {
                for (int i = 0; //*FOR*
                    i < 10;
                    i++)
                {
                    caseSwitch = 2;
                }
            }

            //*type parameters*
            class C1<T1,
                T2,
                T3>
                where T1 : I1
                where T2 : I2
            {
            }

            //*outdent commas*
            void fooCall(
                int firstParameter,
                int secondParameter)
            {
                fooCall(
                    firstParameter
                    , secondParameter);
                fooCall(firstParameter
                    , secondParameter);
            }
        }

        //TODO Tabs Indents Alignment/Align similar code in columns
        public class AlignSimilarCodeInColumns
        {
            //for /Align similar code in columns(Fix column alignment in adjacent lines, Fields and constants﻿, 
            //Properties and events, Simple methods, operators, delegates, Multiline method signature, 
            //Variables and local constants﻿, Other assignments and initializers﻿, Property patterns﻿,
            //Nested ternary operators, Invocations of the same method﻿, Binary expressions﻿, Simple switch sections﻿,
            //Switch expressions﻿,
            //End comments﻿

            //*fields and constants*
            class C
            {
                [Attr]
                private readonly string x1 = "x";

                [Attr]
                public A xxxxx1 = "xxxxx";

                [Attr, Attr1]
                private string xxx1;
            }

            internal class Attr1Attribute : Attribute
            {
            }

            internal class AttrAttribute : Attribute
            {
            }

            class A
            {
                public static A Default { get; internal set; }

                public static implicit operator A(string v)
                {
                    throw new NotImplementedException();
                }
            }

            //*properties and events*
            class B
            {
                [Attr]
                private string x { get; set; } = "x";

                [Attr]
                public A xxxxx { get; set; } = A.Default;

                [Attr, Attr1]
                private string xxx { get; }

                [Attr]
                private string x2 => "x";

                [Attr]
                public A xxxxx2 => "xxxxx";

                [Attr, Attr1]
                private string xxx2 => "xxx";
            }

            //*simple methods, operators, delegates, multiline method signature,*
            class D
            {
                [Attr]
                private string x(int p) { return "x" + p; }

                [Attr]
                public A xxxxx(string b) { return b; }

                [Attr, Attr1]
                private string xxxxx() { return null; }

                [Attr]
                private string x2(int p) => "x" + p;

                [Attr]
                public A xxxxx2(string b) => b;

                [Attr, Attr1]
                private string xxx() => null;
            }

            //*nested ternary operator*
            object x =
                y == "a" ? 1 :
                y == "aaaa" ? 4 :
                y == "aa" ? 2 :
                0;

            private int xx;
            private int xxxx;
            private static string y;

            void fooCall(
                int firstParameter,
                int secondParameter)
            {
                //*variables and local constants*
                {
                    var x = 1;
                    var xxxxx = 2;
                    var xxx = 2;
                }

                //*others*
                {
                    x = 1;
                    xx = 1;
                    xxxx = 1;
                }

                //*inovocations of the same method*
                fooCall(
                    firstParameter
                    , secondParameter);
                fooCall(firstParameter
                    , secondParameter);

                //binary
                if (
                    firstParameter == 0 ||
                    firstParameter > 10 && secondParameter < 5 ||
                    secondParameter > 2 && firstParameter > 3 ||
                    firstParameter == 5)
                {
                    firstParameter += 1;
                }

                //end comments
                fooCall(
                    firstParameter
                    , secondParameter); //comments
                double thirdParameter = 3.2344; //comments
            }

            //*property patterns﻿*
            bool matches = sourceObject is MyType
            {
                FShort: 1,
                FieldLongLong: 2,
            };

            private static MyType sourceObject;
            class Bank
            {
                public BankBranchStatus Status { get; set; }
            }

            enum BankBranchStatus
            {
                Open,
                Closed,
                VIPCustomersOnly
            }

            //*switch simple section*
            static bool CheckIfCanWalkIntoBankSwitch(Bank bank, bool isVip)
            {
                bool result = false;

                switch (bank.Status)
                {
                    case BankBranchStatus.Open: break;
                    case BankBranchStatus.Closed: break;
                    case BankBranchStatus.VIPCustomersOnly: break;
                }

                return result;
            }

            //*switch expressions*
            static bool CheckIfCanWalkIntoBank(Bank bank, bool isVip)
            {
                var result = bank.Status switch
                {
                    BankBranchStatus.Open => true,
                    BankBranchStatus.Closed => false,
                    BankBranchStatus.VIPCustomersOnly => isVip
                };

                return result;
            }
            }
        }
    }
    

    internal class MyType
    {
        public int FShort { get; internal set; }

        public int FieldLongLong { get; internal set; }

        public int Field1 { get; internal set; }

        public int Field2 { get; internal set; }

        public int F1 { get; internal set; }

        public int F2 { get; internal set; }
    }

    public class Order
    {
        public Order AddCustomerDetails(string name)
        {
            return this;
        }

        public Order AddItem(string code, int qty)
        {
            return this;
        }

        public Order AddShippingDetails(string address,
                                        string city,
                                        string postalcode)
        {
            return this;
        }

        public Order Process()
        {
            return this;
        }
    }

    internal interface Someinterface
    {
    }

    internal class I2
    {
    }

    internal class I1
    {
    }


