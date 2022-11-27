using System;
using System.Windows.Forms;

namespace Education_Center.Classes
{
	internal class ClientTreeNode : ManagerTreeNode
	{
		internal ClientTreeNode()
		{
			
		}

		private int clientID;
		internal int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		private int groupID;
		internal int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		private int courseID;
		internal int CourseID
		{
			get { return courseID; }
			set { courseID = value; }
		}	

		private string firstName;
		internal string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;
		internal string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private string fatherName;
		internal string FatherName
		{
			get { return fatherName; }
			set { fatherName = value; }
		}

		private string linkData;
		internal string LinkData
		{
			get { return linkData; }
			set { linkData = value; }
		}

		private DateTime recorddate;
		internal DateTime RecordDate
		{
			get { return recorddate; }
			set { recorddate = value; }
		}

		private string note;
		internal string Note
		{
			get { return note; }
			set { note = value; }
		}

		private string paymentType;
		internal string PaymentType
		{
			get { return paymentType; }
			set { paymentType = value; }
		}

		private double clientSumm;
		internal double ClientSumm
		{
			get { return clientSumm; }
			set { clientSumm = value; }
		}

		internal override void GetChilds()
		{

		}
		
		public override string ToString()
		{
			return  lastName + " " + firstName + " " + fatherName;
		}
	}
}