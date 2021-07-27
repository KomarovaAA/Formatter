// Formatter // for Blank Lines In Declarations(After file header comment﻿)

//for Blank Lines In Declarations(Between different "using" groups﻿, After "using" list﻿)

using System;
using Formatter;

namespace Formatter
{
    public class Blank_Lines
    {
        //TODO Blank Lines/General
        public abstract class General
        {
            //for General(Around regions, Inside regions, Before single line comment)

            protected abstract void Method1(); 

            #region Region Description

            protected abstract void Method2();

            #endregion

            protected abstract void Method3();
            
            //single line comment
        }

        //TODO Blank Lines/Blank Lines In Code
        public abstract class BlankLinesInCode
        {
            //for Blank lines in code(Keep max blank lines in code, Remove blank lines after "{" and before "}" in code﻿,
            //Around local function, Before multiline statements﻿, After multiline statements)

            void Method1()
            {
                //*local function*
                void LocalFunction1(int a, int b) 
                {
                    LocalFunction2();
                }

                //*blank lines after "{" and before "}"*
                void LocalFunction2()
                {
                }

                //*single line local function*
                void LocalFunction3(){} 
                void LocalFunction4(){}
            }

            //for Blank lines in code(Before statements with control transfer﻿, After statements with control transfer﻿,
            //Before statements with child blocks, After statements with child blocks, Around "case" section with a block in switch statement,
            //Around multiline "case" section in switch statement﻿, Before "case" in switch statement﻿, After "case" in switch statement﻿)

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
                    case 2:
                    {
                        int two = 2;
                        break;
                    }

                    default:
                    {
                        int three = 3;
                        break;
                    }
                }

                switch (caseSwitch)
                {
                    default:
                    {
                        int three = 3;
                        break;
                    }
                }
            }
        }

        //TODO Blank Lines/Blank Lines In Declaration
        public abstract class BlankLinesInDeclaration
        {
            //for Blank lines in declarations(Keep max blank lines in declarations, Remove blank lines after { and before } in declarations,
            //Around field﻿, Around single line field﻿,
            //Around property/event, Around single line property/event, Around auto/abstract property/event,
            //Around single line auto/abstract property/event, Around property/event accessor﻿, Around single line property/event accessor,
            //Around type, Around single-line type, Inside type)

            // *field*
            /// <summary>x description</summary>
            private int var1;

            /// <summary>y description</summary>
            private int var2;

            // *single line field*
            private int var3; 
            private int var4;

            // *property/event*
            public int X1
            {
                get { return 1; }
            }

            /// <summary>y description</summary>
            public int Y1
            {
                get { return 2; }
            }

            // single line *property/event*
            public int X2 { get { return 1; } }

            public int Y2 { get { return 2; } }

            // *auto/abstract property/event*
            /// <summary>x description</summary>
            public int X3 { get; set; } 

            /// <summary>x description</summary>
            public int Y3 { get; set; }

            // *single line auto/abstract property/event*
            public int X4 { get; set; }

            public int Y4 { get; set; }

            // *property/event accessor*
            public int X5 
            {
                get
                {
                    Function1();
                    return 1;
                }

                set
                {
                    Function1();
                    var1 = value;
                }
            }

            //*single line property/event accessor*
            public int Y5 //*single line property/event accessor*
            {
                get { return 1; }
                set { var2 = value; }
            }

            //*method*
            void Method1(object a, object b) 
            {
                void LocalFunction1()
                {
                }
            }

            void Method2()
            {
                void LocalFunction2()
                {
                }
            }

            // *single line method*
            protected abstract void Method3(); 

            protected abstract void Method4();

            //*type, single line type*
            class Class1{}

            class Class2
            {
            }

            private void Function1()
            {
                
            }
        }
    }
}


//for Blank Lines In Declarations(﻿Around namespace﻿, Inside namespace)

namespace A { }
namespace B { }