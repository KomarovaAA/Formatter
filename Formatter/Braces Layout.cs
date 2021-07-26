// Formatter

//for Braces Layout(Indent inside namespace declaration, Type and namespace declaration﻿)
using System;

namespace Formatter
{
    public class Braces_Layout
    {
        //for Braces Layout(Method declaration, Lambda and delegate (anonymous method declaration), Property Declaration,
        //Accessor declaration, Block under "case" label, Expressions (initializers, switch expressions, patterns)﻿,
        //Use continuous line indent inside expression braces﻿, Other﻿, Allow comment after '{'﻿, Empty braces formatting)

        //*property*
        public int X { get; set; }

        // *accessor*
        public int Y 
        {
            get
            {
                Function1();
                return 1;
            }

            set
            {
                Function1();
            }
        }

        private void Function1()
        {
            int caseSwitch = 1;

            //*"case" label*
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

            //*other, comment*
            if (caseSwitch < 1)
            {//comment
                Function1();
            }
            else
            {
                Function1();
            }
        }

        //*method*
        void Method1()
        {
            void LocalFunction1(int a, int b)
            {
                LocalFunction2();
            }

            //*empty braces*
            void LocalFunction2()
            {
            }
        }

        //*delegate*
        delegate void D();

        private D d = delegate()
        {
            int x = 0;
        };

        //*expressions(initializers, switch expressions, patterns)*
        int[] array = new int []
        {
            1, 2, 3
        };
    }
}
        


