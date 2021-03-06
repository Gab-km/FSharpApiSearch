﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLoadTestAssembly
{
    public class StaticMemberClass
    {
        public StaticMemberClass() { }

        public StaticMemberClass(string x, string y) { }

        public static int StaticMethod1() => 0;
        public static double StaticMethod2(int x, int y, string z) => 0;
        public static void StaticMethod3() { }

        public static int StaticProperty { get; set; }
        public static int StaticField;

        public static int[] ArrayMethod() => null;
        public static int[,] Array2dMethod() => null;
        public static int[,][] NestedArrayMethod() => new[,] { { new int[0], new int[0] } };
    }

    public class OuterClass
    {
        public class InnerClass
        {
            public InnerClass() { }
            public static int StaticMethod() => 3;
        }
    }
}
