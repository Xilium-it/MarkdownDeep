using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MarkdownDeep;

namespace MarkdownDeepTests
{
	[TestFixture]
	class TableSpecTests
	{
		[SetUp]
		public void SetUp()
		{
		}

		TableSpec Parse(string str)
		{
			var s = new StringScanner(str);
			return TableSpec.Parse(s);
		}

		[Test]
		public void Simple()
		{
			var s = Parse("--|--");

			Assert.IsNotNull(s);
			Assert.IsFalse(s.LeadingBar);
			Assert.IsFalse(s.TrailingBar);
			Assert.AreEqual(2, s.Columns.Count);
			Assert.AreEqual(TableCellAlignment.NA, s.Columns[0]);
			Assert.AreEqual(TableCellAlignment.NA, s.Columns[1]);
		}

		[Test]
		public void Alignment()
		{
			var s = Parse("--|:--|--:|:--:");

			Assert.IsNotNull(s);
			Assert.IsFalse(s.LeadingBar);
			Assert.IsFalse(s.TrailingBar);
			Assert.AreEqual(4, s.Columns.Count);
			Assert.AreEqual(TableCellAlignment.NA, s.Columns[0]);
			Assert.AreEqual(TableCellAlignment.Left, s.Columns[1]);
			Assert.AreEqual(TableCellAlignment.Right, s.Columns[2]);
			Assert.AreEqual(TableCellAlignment.Center, s.Columns[3]);
		}

		[Test]
		public void LeadingTrailingBars()
		{
			var s = Parse("|--|:--|--:|:--:|");

			Assert.IsNotNull(s);
			Assert.IsTrue(s.LeadingBar);
			Assert.IsTrue(s.TrailingBar);
			Assert.AreEqual(4, s.Columns.Count);
			Assert.AreEqual(TableCellAlignment.NA, s.Columns[0]);
			Assert.AreEqual(TableCellAlignment.Left, s.Columns[1]);
			Assert.AreEqual(TableCellAlignment.Right, s.Columns[2]);
			Assert.AreEqual(TableCellAlignment.Center, s.Columns[3]);
		}


		[Test]
		public void Whitespace()
		{
			var s = Parse(" | -- | :-- | --: | :--: |  ");

			Assert.IsNotNull(s);
			Assert.IsTrue(s.LeadingBar);
			Assert.IsTrue(s.TrailingBar);
			Assert.AreEqual(4, s.Columns.Count);
			Assert.AreEqual(TableCellAlignment.NA, s.Columns[0]);
			Assert.AreEqual(TableCellAlignment.Left, s.Columns[1]);
			Assert.AreEqual(TableCellAlignment.Right, s.Columns[2]);
			Assert.AreEqual(TableCellAlignment.Center, s.Columns[3]);
		}


	}
}
