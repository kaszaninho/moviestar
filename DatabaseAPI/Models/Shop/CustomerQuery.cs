﻿using DatabaseAPI.Models.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseAPI.Models.Shop
{
	public class CustomerQuery : DictionaryTable
	{
		public string Email { get; set; }
		public string ContactNumber { get; set; }
		public bool IsAnswered { get; set; }
	}
}
