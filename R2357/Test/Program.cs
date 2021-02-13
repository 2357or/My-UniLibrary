using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using R2357.Extensions;
using R2357.Algorithm;
using static System.Console;

namespace Test {
    public class Program {

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
            //const int MAX = 10000000;
            //var stopWatch = StopWatch.Create();

            //var list = new List<int>(MAX);
            //for(int i = 0; i<MAX; i++) {
            //    var v = random.Next(1000000);
            //    list.Add(v);
            //}

            //list.Sort();

            //long time = 0;
            //for(int i = 0; i < 10; i++) {
            //    stopWatch.start();
            //    var t = list.BinarySearch(random.Next(1000000));
            //    stopWatch.stop().write();
            //    time += stopWatch.time();
            //    WriteLine(t);
            //}
            //WriteLine(time/10);

            var t = new List<int> { 1, 2, 4 };

            return true;
        }
    }
    public class Greater : Comparer<int> {
        public override int Compare(int x, int y) {
            return y - x;
        }
    }

    #region Stopwatch extention
    public static class StopWatch {
        public static Stopwatch Create() => new Stopwatch();
        public static void start(this Stopwatch stopwatch) {
            Console.WriteLine("\nStart time measurement");
            stopwatch.Start();
        }
        public static Stopwatch stop(this Stopwatch stopwatch) {
            stopwatch.Stop();
            return stopwatch;
        }
        public static Stopwatch write(this Stopwatch stopwatch) {
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms");
            return stopwatch;
        }
        public static Stopwatch reset(this Stopwatch stopwatch) {
            stopwatch.Reset();
            return stopwatch;
        }
        public static long time(this Stopwatch stopwatch) => stopwatch.ElapsedMilliseconds;
    }
    #endregion
}
