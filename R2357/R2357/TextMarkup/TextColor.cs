namespace R2357.TextMarkup {

    /// <summary>
    /// The HelperClass of TextColor(Enum).
    /// </summary>
    public static class TextColorHelper {

        /// <summary>
        /// Return the TextColor as a hexadecimal number.
        /// </summary>
        public static string HexNumber(this TextColor textColor) {
            string hexNumber = null;
            switch(textColor) {
                case TextColor.aqua:
                    hexNumber = "00ffffff";
                    break;
                case TextColor.black:
                    hexNumber = "000000ff";
                    break;
                case TextColor.blue:
                    hexNumber = "0000ffff";
                    break;
                case TextColor.brown:
                    hexNumber = "a52a2aff";
                    break;
                case TextColor.cyan:
                    hexNumber = "00ffffff";
                    break;
                case TextColor.darkblue:
                    hexNumber = "0000a0ff";
                    break;
                case TextColor.fuchsia:
                    hexNumber = "ff00ffff";
                    break;
                case TextColor.green:
                    hexNumber = "008000ff";
                    break;
                case TextColor.grey:
                    hexNumber = "808080ff";
                    break;
                case TextColor.lightblue:
                    hexNumber = "add8e6ff";
                    break;
                case TextColor.lime:
                    hexNumber = "00ff00ff";
                    break;
                case TextColor.magenta:
                    hexNumber = "ff00ffff";
                    break;
                case TextColor.maroon:
                    hexNumber = "800000ff";
                    break;
                case TextColor.navy:
                    hexNumber = "000080ff";
                    break;
                case TextColor.olive:
                    hexNumber = "808000ff";
                    break;
                case TextColor.orange:
                    hexNumber = "ffa500ff";
                    break;
                case TextColor.purple:
                    hexNumber = "800080ff";
                    break;
                case TextColor.red:
                    hexNumber = "ff0000ff";
                    break;
                case TextColor.silver:
                    hexNumber = "c0c0c0ff";
                    break;
                case TextColor.teal:
                    hexNumber = "008080ff";
                    break;
                case TextColor.white:
                    hexNumber = "ffffffff";
                    break;
                case TextColor.yellow:
                    hexNumber = "ffff00ff";
                    break;
            }
            return hexNumber;
        }
    }

    /// <summary>
    /// Color name of the text markup.
    /// </summary>
    public enum TextColor {
        /// <summary>
        /// #00ffffff
        /// </summary>
        aqua,

        /// <summary>
        /// #000000ff
        /// </summary>
        black,

        /// <summary>
        /// #0000ffff
        /// </summary>
        blue,

        /// <summary>
        /// #a52a2aff
        /// </summary>
        brown,

        /// <summary>
        /// #00ffffff
        /// </summary>
        cyan,

        /// <summary>
        /// #0000a0ff
        /// </summary>
        darkblue,

        /// <summary>
        /// #ff00ffff
        /// </summary>
        fuchsia,

        /// <summary>
        /// #008000ff
        /// </summary>
        green,

        /// <summary>
        /// #808080ff
        /// </summary>
        grey,

        /// <summary>
        /// #add8e6ff
        /// </summary>
        lightblue,

        /// <summary>
        /// #00ff00ff
        /// </summary>
        lime,

        /// <summary>
        /// #ff00ffff
        /// </summary>
        magenta,

        /// <summary>
        /// #800000ff
        /// </summary>
        maroon,

        /// <summary>
        /// #000080ff
        /// </summary>
        navy,

        /// <summary>
        /// #808000ff
        /// </summary>
        olive,

        /// <summary>
        /// #ffa500ff
        /// </summary>
        orange,

        /// <summary>
        /// #800080ff
        /// </summary>
        purple,

        /// <summary>
        /// #ff0000ff
        /// </summary>
        red,

        /// <summary>
        /// #c0c0c0ff
        /// </summary>
        silver,

        /// <summary>
        /// #008080ff
        /// </summary>
        teal,

        /// <summary>
        /// #ffffffff
        /// </summary>
        white,

        /// <summary>
        /// #ffff00ff
        /// </summary>
        yellow
    }
}