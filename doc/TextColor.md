# TextColor
テキスト装飾に使う基本的な色の列挙型.



## 列挙型


### TextColor
| 名前      | カラーコード(16進数) | 色見本 |
| :---      | :------------------: | :----: |
| aqua      | #00ffffff            |        |
| black     | #000000ff            |        |
| blue      | #0000ffff            |        |
| brown     | #a52a2aff            |        |
| cyan      | #00ffffff            |        |
| darkblue  | #0000a0ff            |        |
| fuchsia   | #ff00ffff            |        |
| green     | #008000ff            |        |
| grey      | #808080ff            |        |
| lightblue | #add8e6ff            |        |
| lime      | #00ff00ff            |        |
| magenta   | #ff00ffff            |        |
| maroon    | #800000ff            |        |
| navy      | #000080ff            |        |
| olive     | #808000ff            |        |
| orange    | #ffa500ff            |        |
| purple    | #800080ff            |        |
| red       | #ff0000ff            |        |
| silver    | #c0c0c0ff            |        |
| teal      | #008080ff            |        |
| white     | #ffffffff            |        |
| yellow    | #ffff00ff            |        |



## ヘルパークラス(TextColorHelper)


### .HexNumber()
`TextColor`に対応した16進数を返す拡張メソッド.  

- `HexNumber(this TextColor textColor) -> string`