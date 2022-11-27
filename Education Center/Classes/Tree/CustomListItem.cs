using System;
using System.Data;

namespace Education_Center.Classes
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	// ����� �������� ������ ��� ������� ������� �� ��
	public class CustomListItem : System.Windows.Forms.ListViewItem
	{
		public CustomListItem():base()
		{
			bindedRow = null;
		}

		public CustomListItem(string[] subItems, int imageIndex):base(subItems, imageIndex)
		{
			bindedRow = null;
		}

		private DataRow bindedRow;
		/// <summary>
		/// Gets or sets binded row from table for item that is displayed on the ListView
		/// </summary>
		internal DataRow BindedRow
		{
			get { return bindedRow; }
			set { bindedRow = value; }
		}
	}
}