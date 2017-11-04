using System.Collections.Generic;

namespace Utils {
    public class NumberedButtonClickHelper {
        // Parse Button's name and return result.
        // string:  ButtonName
        // int:     Index
        public static KeyValuePair<string, int> Parse(string name) {
            // 'button', '($number)'
            string[] split = name.Split(' ');
            // $number)
            string withoutLeftParen = split[1].Substring(1);
            // $number
            string withoutRightParen = withoutLeftParen.Substring(0, withoutLeftParen.Length - 1);
            int index = int.Parse(withoutRightParen);
            return new KeyValuePair<string, int>(split[0], index);
        }
    }
}