﻿using System;

namespace Static
{
    static class MyClass
    {
        #region MyRegion
        static string variable = null;
        /*public*/
        static MyClass() => variable = "Hello world!";
        public static void DisplayVariable() => Console.WriteLine(variable);
        public static string Property { set => variable = value; }

        /*static*/
        const double PI = 3.14; // Константа

        // Индексатор не может быть статическим! 
        #endregion

        public static NestedClass Instance = new NestedClass();
        public class NestedClass // Non-static class 
        {
            public void MethodFromNestedClass() => Console.WriteLine("Hello from NC");
        }
        public static class StaticNestedClass
        {
            public static void MethodFromNestedStaticClass() => Console.WriteLine("Hello from Static NC");
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass.Instance.MethodFromNestedClass();
            MyClass.StaticNestedClass.MethodFromNestedStaticClass();

            //MyClass instance = new MyClass();
            MyClass.DisplayVariable();
            MyClass.Property = "Привет мир!";
            MyClass.DisplayVariable();
        }
    }
}
