using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PringPossibleWordsOfPhoneDigits
{
    class PringWordsUsingPhoneDigits
    {
        public static String[,] mappings = new String[,]{
            {"0"}, {"1"}, {"A", "B", "C"}, {"D", "E", "F"}, {"G", "H", "I"},
            {"J", "K", "L"}, {"M", "N", "O"}, {"P", "Q", "R", "S"}, 
            {"T", "U", "V"}, {"W", "X", "Y", "Z"}
        };

        public static void generateCombosHelper(List<String> combos, 
            String prefix, String remaining) {
        // The current digit we are working with
        int digit = int.Parse(remaining.Substring(0, 1));

        if (remaining.Length == 1) {
            // We have reached the last digit in the phone number, so add 
            // all possible prefix-digit combinations to the list
            for (int i = 0; i < mappings[digit].length; i++) {
                combos.add(prefix + mappings[digit][i]);
            }
        } else {
            // Recursively call this method with each possible new 
            // prefix and the remaining part of the phone number.
            for (int i = 0; i < mappings[digit].length; i++) {
                generateCombosHelper(combos, prefix + mappings[digit][i], 
                        remaining.substring(1));
            }
        }
    }

    }
}
