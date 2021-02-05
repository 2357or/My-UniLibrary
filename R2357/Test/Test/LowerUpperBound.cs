using System;
using System.Collections.Generic;
using R2357.Algorithm;
using Test.Protocol;

namespace Test {

    public class LowerBoundTest
        : TestData<LowerUpperBoundTestCase, LowerUpperBoundTestResult> {

        public override void RunTest(int i, bool showRet = false) {
            int ret = Search.LowerBound(caseList[i].Array, caseList[i].Key);
            Judge(id: i, judge: ret == resultList[i].Result);
            if(showRet) Console.WriteLine($"ret: {ret}");
        }
    }

    public class UpperBoundTest
        : TestData<LowerUpperBoundTestCase, LowerUpperBoundTestResult> {

        public override void RunTest(int i, bool showRet = false) {
            int ret = Search.UpperBound(caseList[i].Array, caseList[i].Key);
            Judge(id: i, judge: ret == resultList[i].Result);
            if(showRet) Console.WriteLine($"ret: {ret}");
        }
    }

    public struct LowerUpperBoundTestCase : ITestCase {
        public LowerUpperBoundTestCase(List<int> Array, int Key) {
            this.Array = Array;
            this.Key = Key;
        }
        public List<int> Array { get; private set; }
        public int Key { get; private set; }
        public void Write() {
            foreach(var x in Array) {
                Console.Write($" {x}");
            }
            Console.Write($"\nKey: {Key}\n");
        }
    }

    public struct LowerUpperBoundTestResult : ITestResult {
        public LowerUpperBoundTestResult(int Result) {
            this.Result = Result;
        }
        public int Result { get; private set; }
        public void Write() {
            Console.WriteLine(Result);
        }
    }
}