# Search
探索を行います.



## 関数


### LowerBound
昇順ソートされた`List<T>`に対し、指定された要素以上の値が現れる最初のインデックスを返します.  
また、このアルゴリズムは二分探索で実装されています.

- `LowerBound<T>(List<T> list, T key) where T : IComparable -> int`
- `LowerBound<T>(List<T> list, T key, Comparer<T> comparer) -> int`


### UpperBound
昇順ソートされた`List<T>`に対し、指定された要素より大きいの値が現れる最初のインデックスを返します.  
また、このアルゴリズムは二分探索で実装されています.

- `UpperBound<T>(List<T> list, T key) where T : IComparable -> int`
- `UpperBound<T>(List<T> list, T key, Comparer<T> comparer) -> int`
