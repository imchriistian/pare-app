﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
	public abstract class Result
	{
		public bool IsSuccess { get; set; }
		public int Code { get; set; }
		public int Count { get; set; }
		public string Message { get; set; }
		public Exception Error { get; set; }
	}
}
