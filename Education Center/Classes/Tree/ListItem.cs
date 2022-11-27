using System;
using System.Data;
using System.Data.SqlClient;

namespace Education_Center.Classes
{
	/// <summary>
	/// ���� ����� ������������ ����� ������� � ������
	/// </summary>
	internal class ListItem
	{
		private DataRow itemRow = null;

		/// <summary>
		/// ��� �������� �������� ������ ��� ������. ��� ���������� DataRow ������� item � ������
		/// </summary>
		

		internal ListItem()
		{
			this.text = "";
		}

		internal ListItem(DataRow row)
		{
			this.text = "";
			this.itemRow = row;
		}
		
		private string text;
		internal string Text
		{
			get { return text; }
			set { text = value; }
		}

		internal DataRow ItemRow
		{
			get { return itemRow; }
		}
	}
}