# テストの使い方


## 用意するのも
- テストケース
- テスト結果
- テスト実行クラス


### テストケース
`ITestCase`を継承したstructを作成する  
コンストラクタとプロパティを定義する  
`Write()`は自身のテストケースをコンソールに表示する処理を書く  


### テスト結果
`ITestResult`を継承したstructを作成する  
テストケースと同じ要領で内容を定義する  


### テスト実行クラス
TestData<テストケース, テスト結果>を継承したclassを作成する  
`RunTest(int)`をオーバーライドしてテストを実行する  



## 実装
- ITestCase
- ITestResult
- TestData\<Case, Result\>


### ITestCase
テストケースのデータ型  
`void Write()` : 自身のテストケースをコンソールに表示する  


### ITestResult
テスト結果のデータ型  
`void Write()` : 自身のテスト結果をコンソールに表示する  


### TestData\<Case, Result\>
テストを実行する本体  
Case : `ITestCase`  
Result : `ITestResult`  

プロパティ  
`caseList` : テストケースのリスト  
`resultList` : テスト結果のリスト  

公開メソッド  
`Add(ITestCase, ITestResult)` : テストケース、結果の追加  
`RunTest(int i)` : i番目のテストを実行する  
`RunAllTest()` : 全てのテストを実行する  

非公開メソッド  
`AddCase(Case)` : テストケースの追加  
`AddResult(Result)` : テスト結果の追加  
`WriteStart(int i)` : "No.{i}"と出力する  
`Judge(int id, bool judge)` : idはテスト番号、judgeは実行結果とテスト結果が一致しているかどうか、judgeがfalseの場合テストケースの値とテスト結果(期待した値)を出力する  