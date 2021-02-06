# ListExtension
`List<T>`型の小規模な拡張メソッド群.



## 関数


### Back
Listの最後の要素を返します.

- `Back<T>(this List<T> list) -> T`


### Front
Listの最初の要素を返します.

- `Front<T>(this List<T> list) -> T`


### Sorted
Listを昇順にソートし、そのListを返します.  
Sort()ではできなかった、メソッドチェーンによるソートや引数にListを渡す直前にソートすることができます.

- `Sorted<T>(this List<T> list) -> List<T>`

###  Reversed
Listの要素の順序を逆転んさせ、そのListを返します.  
Reverse()ではできなかった、メソッドチェーンによる順序反転や引数にListを渡す直前に順序反転をすることができます.

- ` Reversed<T>(this List<T> list) -> List<T>`

### MaxElement
List内の最大の要素を返します.  
内部にて`IComparable`へのキャストが行いますが、キャストをしない場合との処理速度との差は要素数が1e6のListで5ms程度です.

- `MaxElement<T>(this List<T> list) where T : IComparable -> T`

### MinElement
List内の最小の要素を返します.  
内部にて`IComparable`へのキャストが行いますが、キャストをしない場合との処理速度との差は要素数が1e6のListで5ms程度です.

- `MinElement<T>(this List<T> list) where T : IComparable -> T`