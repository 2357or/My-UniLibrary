using System;
using System.Collections.Generic;

namespace Test.Protocol {

    /// <summary>
    /// テストケースのデータ型
    /// </summary>
    public interface ITestCase {
        /// <summary>
        /// 自身のテストケースをコンソールに表示する
        /// </summary>
        void Write();
    }

    /// <summary>
    /// テスト結果のデータ型
    /// </summary>
    public interface ITestResult {
        /// <summary>
        /// 自身のテスト結果をコンソールに表示する
        /// </summary>
        void Write();
    }

    /// <summary>
    /// テストを実行する本体
    /// </summary>
    /// <typeparam name="Case">テストケースのデータ型</typeparam>
    /// <typeparam name="Result">テスト結果のデータ型</typeparam>
    public abstract class TestData<Case, Result>
        where Case : ITestCase
        where Result : ITestResult {

        /// <summary>
        /// テストケースのリスト
        /// </summary>
        protected List<Case> caseList = new List<Case>();

        /// <summary>
        /// テスト結果のリスト
        /// </summary>
        protected List<Result> resultList = new List<Result>();

        /// <summary>
        /// テストケース、結果の追加
        /// </summary>
        /// <param name="testCase"></param>
        /// <param name="testResult"></param>
        public virtual void Add(ITestCase testCase, ITestResult testResult) {
            AddCase((Case)testCase);
            AddResult((Result)testResult);
        }

        /// <summary>
        /// テストケースの追加
        /// </summary>
        /// <param name="testCase"></param>
        protected void AddCase(Case testCase) => caseList.Add(testCase);

        /// <summary>
        /// テスト結果の追加
        /// </summary>
        /// <param name="testResult"></param>
        protected void AddResult(Result testResult) => resultList.Add(testResult);

        /// <summary>
        /// i番目のテストを実行する
        /// </summary>
        /// <param name="i"></param>
        public abstract void RunTest(int i, bool showRet = false);

        /// <summary>
        /// 全てのテストを実行する
        /// </summary>
        public void RunAllTest() {
            for(int i = 0; i < caseList.Count; i++) {
                Console.WriteLine("\nNo." + i.ToString("00"));
                RunTest(i);
            }
        }

        /// <summary>
        /// "No.{i}"と出力する
        /// </summary>
        /// <param name="i"></param>
        protected void WriteStart(int i)
            => Console.WriteLine("\nNo." + (i+1).ToString("00"));

        /// <summary>
        /// idはテスト番号,
        /// judgeは実行結果とテスト結果が一致しているかどうか.
        /// judgeがfalseの場合テストケースの値とテスト結果(期待した値)を出力する.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="judge"></param>
        protected void Judge(int id, bool judge) {
            if(judge) Console.WriteLine("[Accepted]");
            else {
                Console.WriteLine("!!! Error !!!\n--- Input ---");
                caseList[id].Write();
                Console.WriteLine("---Expect---");
                resultList[id].Write();
            }
        }
    }
}
