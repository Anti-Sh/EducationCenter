using System;
using System.Data;
using System.Data.SqlClient;

namespace Education_Center.Classes
{
	/// <summary>
	/// Этот класс представляет собой элемент в списке
	/// </summary>
	internal class ListItem
	{
		private DataRow itemRow = null;

		/// <summary>
		/// Это свойство доступно только для чтения. Оно возвращает DataRow данного item в списке
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