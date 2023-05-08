using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Zadacha04
{
    public class DateModifier
    {
		private DateTime first;

		public DateTime First
		{
			get { return first; }
			set { first = value; }
		}
		private DateTime second;

		public DateTime Second
		{
			get { return second; }
			set { second = value; }
		}
		public void InIt(string d1, string d2)
		{
			this.First = DateTime.ParseExact(d1, "yyyy MM dd", CultureInfo.InvariantCulture);
			this.Second = DateTime.ParseExact(d2, "yyyy MM dd", CultureInfo.InvariantCulture);
		}
		public int GetDifference()
		{
			return Math.Abs(this.First.Subtract(this.Second).Days);
		}

	}
}
