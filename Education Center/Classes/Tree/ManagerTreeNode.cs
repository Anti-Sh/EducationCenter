using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Education_Center.Classes
{
	internal abstract class ManagerTreeNode : TreeNode
	{
		internal abstract void GetChilds();

		internal DataTable SelectData(string query)
		{
			string source = "Initial Catalog=AAAAA;Data Source=localhost;Integrated Security=SSPI;";
			SqlConnection conn = new SqlConnection(source);
				
			try
			{
				conn.Open();
				
				SqlCommand selectCommand = new SqlCommand();
				selectCommand.CommandText = query;
				selectCommand.Connection = conn;
				
				SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
				DataTable dt = new DataTable();
				adapter.Fill(dt); // В dt находится таблица с данными
			
				conn.Close();
				
				return dt;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);

				return null;
			}
			finally
			{
				conn.Close(); 
			}
		}		
	}
}