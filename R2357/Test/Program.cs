using System;
using static System.Console;
using R2357.Extensions;
using R2357.Algorithm;
using System.Collections.Generic;
using UnityEngine;
using Test.Protocol;

namespace Test {
    class Program {

        public static void Main() {
            bool BOOL = Other();
            if(BOOL) return;

            WriteLine("Test Start");


            // テストするクラスをインスタンス化
            var testData = new UpperBoundTest();
            

            // テストケースの追加


            // テスト実行
            testData.RunAllTest();
            //testData.RunTest(9, true);
        }

        private static bool Other() {
            //var random = new System.Random(1);
            //const int MAX = 1000000;
            //StopWatch stopWatch = new StopWatch();

            var list = new List<long>() {
                1,4,2,5,3,1,3456,12
            };
            var maxe = list.MaxElement();
            WriteLine(maxe);
            var mine = list.MinElement();
            WriteLine(mine);
            



            return true;
        }
    }
}
