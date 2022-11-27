using System;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Education_Center.Forms;

namespace Education_Center.Classes
{
	internal class GroupTreeNode : ManagerTreeNode
	{
		private int courseID;
		internal int CourseID
		{
			get { return courseID; }
			set { courseID = value; }
		}

		private int groupID;
		internal int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}
		
		private DateTime beginDate;
		internal DateTime BeginDate
		{
			get { return beginDate; }
			set { beginDate = value; }
		}

		private	DateTime endDate;
		internal DateTime EndDate
		{
			get { return endDate; }
			set { endDate = value; }
		}

		private	DateTime beginTime;
		internal DateTime BeginTime
		{
			get { return beginTime; }
			set { beginTime = value; }
		}

		private	DateTime endTime;
		internal DateTime EndTime
		{
			get { return endTime; }
			set { endTime = value; }
		}

		private	int clientsCount;
		internal int ClientsCount
		{
			get { return clientsCount; }
			set { clientsCount = value; }
		}

		private	int classNumber;
		internal int ClassNumber
		{
			get { return classNumber; }
			set { classNumber = value; }
		}

		private	int directionID;
		internal int DirectionID
		{
			get { return directionID; }
			set { directionID = value; }
		}

		private	int employeeID;
		internal int EmployeeID
		{
			get { return employeeID; }
			set { employeeID = value; }
		}

		private	string groupNote;
		internal string GroupNote
		{
			get { return groupNote; }
			set { groupNote = value; }
		}

		private	int status;
		internal int Status
		{
			get { return status; }
			set { status = value; }
		}

		internal override void GetChilds()
		{
			DataView dvGroupClients = new DataView(MySQL.GetDataBase("group_clients"));
			dvGroupClients.RowFilter = "groupID = " + this.GroupID.ToString();
				
			ClientTreeNode[] ctns = new ClientTreeNode[dvGroupClients.Count];
			ClientTreeNode ctn = null;
				
			int i = 0;
			foreach(DataRowView drv in dvGroupClients)
			{
				DataRow clientRow = drv.Row.GetParentRow("clientsgroup_clients");
				ctn = new ClientTreeNode();
				
				ctn.ClientID = (int)clientRow["ClientID"];
				ctn.FirstName = clientRow["fname"].ToString(); 
				ctn.LastName = clientRow["lname"].ToString();
				ctn.FatherName = clientRow["fathName"].ToString();
				ctn.LinkData = clientRow["linkData"].ToString();
				ctn.RecordDate = (DateTime)clientRow["recordDate"];
				ctn.Note = clientRow["note"].ToString();
				ctn.PaymentType = clientRow["paymentType"].ToString();
				
				ctn.Text = ctn.LastName + " " + ctn.FirstName + " " + ctn.FatherName;
				ctn.ImageIndex = 6;
				ctn.ForeColor = Color.Teal;

				ctn.Tag = clientRow;
				
				ctns[i++] = ctn;
				ctn = null;
			}
			
			this.ForeColor = Color.Crimson;
			this.Nodes.AddRange(ctns);
		}
	}
}