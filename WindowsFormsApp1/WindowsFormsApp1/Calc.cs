﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calc
    {
        public static string Plus(string A, string B)
        {
            RimNumber rim1 = new RimNumber(A);
            RimNumber rim2 = new RimNumber(B);
            return rim1 + rim2;
        }
        public static string Minus(string A, string B)
        {
            RimNumber rim1 = new RimNumber(A);
            RimNumber rim2 = new RimNumber(B);
            return rim1 - rim2;
        }
        public static string Multiply(string A, string B)
        {
            RimNumber rim1 = new RimNumber(A);
            RimNumber rim2 = new RimNumber(B);
            return rim1 * rim2;
        }
        public static string Divide(string A, string B)
        {
            RimNumber rim1 = new RimNumber(A);
            RimNumber rim2 = new RimNumber(B);
            return rim1 / rim2;
        }
        public static string Percent(string A, string B)
        {
            RimNumber rim1 = new RimNumber(A);
            RimNumber rim2 = new RimNumber(B);
            return rim1 % rim2;
        }
        public static int RimToArab(string rim)
        {
            return RimNumber.ChangeRimToArab(rim);
        }
        public static string ArabToRim(int arab)
        {
            return RimNumber.ChangeArabToRim(arab);
        }

        public static void GetFunction(string _rim1, string _rim2, string _znak) //для математических действий
        {
            string rim1 = _rim1;
            string rim2 = _rim2;
            string znak = _znak;
        }

        public static void GetFunction(string _rim1, string _znak) // для перевода из арабских в римские и наоборот
        {
            string rim1 = _rim1;
            string znak = _znak;
        }
    }
}
