using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TRANTHITHANHNGAN_5951071061.Models
{
	[Datacontract]
	public class StudentInfo
	{
		[DataMember ( Name = "hovaten")]

		public string Hovaten { get; set; }
		[DataMember (Name ="mssv")]
		public string Mssv { get; set; }

		[DataMember (Name = "lop")]
		public string Lop { get; set; }



	}
}