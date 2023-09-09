using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha02
{
    class RationalNumber
    {
		private int numerator;

		public int Numerator
		{
			get { return numerator; }
			set { numerator = value; }
		}
		private int denumerator;

		public int Denumerator
		{
			get { return denumerator; }
			set { denumerator = value; }
		}

        public RationalNumber(int numerator, int denumerator)
        {
            Numerator = numerator;
            Denumerator = denumerator;
        }

        public override string ToString()
        {
			return $"{Numerator}/{Denumerator}";
        }
    }
}
