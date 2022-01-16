using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClock
{
    class Components
    {
        private static List<int> ALL_EMPTY = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> ALL_FILLED = new List<int> { 1, 1, 1, 1, 1 };
        private static List<int> DOUBLE_DOT = new List<int> { 1, 0, 0, 0, 1 };
        private static List<int> DOT_RIGHT = new List<int> { 0, 0, 0, 0, 1 };
        private static List<int> DOT_LEFT = new List<int> { 1, 0, 0, 0, 0 };
        private static List<int> DOT_MIDDLE = new List<int> { 0, 0, 1, 0, 0 };

        public static List<List<int>> DIGIT_ZERO = new List<List<int>> { ALL_FILLED, DOUBLE_DOT, DOUBLE_DOT, DOUBLE_DOT, ALL_FILLED };
        public static List<List<int>> DIGIT_ONE = new List<List<int>> { DOT_RIGHT, DOT_RIGHT, DOT_RIGHT, DOT_RIGHT, DOT_RIGHT };
        public static List<List<int>> DIGIT_TWO = new List<List<int>> { ALL_FILLED, DOT_RIGHT, ALL_FILLED, DOT_LEFT, ALL_FILLED };
        public static List<List<int>> DIGIT_THREE = new List<List<int>> { ALL_FILLED, DOT_RIGHT, ALL_FILLED, DOT_RIGHT, ALL_FILLED };
        public static List<List<int>> DIGIT_FOUR = new List<List<int>> { DOUBLE_DOT, DOUBLE_DOT, ALL_FILLED, DOT_RIGHT, DOT_RIGHT };
        public static List<List<int>> DIGIT_FIVE = new List<List<int>> { ALL_FILLED, DOT_LEFT, ALL_FILLED, DOT_RIGHT, ALL_FILLED };
        public static List<List<int>> DIGIT_SIX = new List<List<int>> { ALL_FILLED, DOT_LEFT, ALL_FILLED, DOUBLE_DOT, ALL_FILLED };
        public static List<List<int>> DIGIT_SEVEN = new List<List<int>> { ALL_FILLED, DOT_RIGHT, DOT_RIGHT, DOT_RIGHT, DOT_RIGHT };
        public static List<List<int>> DIGIT_EIGHT = new List<List<int>> { ALL_FILLED, DOUBLE_DOT, ALL_FILLED, DOUBLE_DOT, ALL_FILLED};
        public static List<List<int>> DIGIT_NINE = new List<List<int>> { ALL_FILLED, DOUBLE_DOT, ALL_FILLED, DOT_RIGHT, ALL_FILLED };

        public static List<List<int>> SEMI_COLUMN = new List<List<int>> {ALL_EMPTY, DOT_MIDDLE, ALL_EMPTY, DOT_MIDDLE, ALL_EMPTY };
    }
}
