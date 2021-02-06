# <img src="/icons/class.png" width="35px"/>BooleanExtension
`bool`型の小規模な拡張メソッド群.



## 関数


### Not
真偽値を否定します.  
理論演算子`!`をつけたのと同じ処理が行われます.

- `Not(this ref bool b) -> bool`


### Toggle
真偽値を反転させます.  
trueとの排他的理論和を取ります.

- `Toggle(this ref bool b) -> void`