namespace LetterFrequency.Models
{
    public class CharObject
    {
        public char CharValue { get; set; }
        public int IntValue { get; set; }
        public CharObject(char charValue, int intValue)
        {
            CharValue = charValue;
            IntValue = intValue;
        }

        public char ReturnChar
        {
            get
            {
                return CharValue;
            }
            set
            {
                CharValue = value;
            }
        }

        public int ReturnInt
        {
            get
            {
                return IntValue;
            }
            set
            {
                IntValue = value;
            }
        }
    }
}
