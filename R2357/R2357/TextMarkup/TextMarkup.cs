using UnityEngine;

namespace R2357.TextMarkup {

    /// <summary>
    /// Add markup to the string.
    /// </summary>
    public static class TextMarkup {

        /// <summary>
        /// Add a tag to specify the `Color` of the text markup.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string SetColor(this string text, Color color) {
            string colorHtml = ColorUtility.ToHtmlStringRGBA(color);
            return $"<color=#{colorHtml}>{text}</color>";
        }

        /// <summary>
        /// Add a tag to specify the `Color` of the text markup.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string SetColor(this string text, TextColor color) {
            return $"<color=#{color.HexNumber()}>{text}</color>";
        }

        /// <summary>
        /// Add a tag to specify the `Size` of the text markup.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string SetSize(this string text, int size) {
            return $"<size={size}>{text}</size>";
        }

        /// <summary>
        /// Add a tag to specify the `Bold` of the text markup.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SetBold(this string text) {
            return $"<b>{text}</b>";
        }

        /// <summary>
        /// Add a tag to specify the `Italic` of the text markup.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SetItalic(this string text) {
            return $"<i>{text}</i>";
        }
    }
}