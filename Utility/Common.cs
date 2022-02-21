﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace LabeledData.Utility
{
	public static class Common
	{
		/// <summary>
		/// Compare password input with Password DB
		/// </summary>
		/// <param name="password"></param>
		/// <param name="hashStr"></param>
		/// <returns></returns>
		public static bool SignIn(string password, string hashStr)
		{
			try
			{
				return PBKDF2.Verify(password, hashStr);
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Hash password 
		/// </summary>
		/// <param name="password"></param>
		/// <returns></returns>
		public static string SignUp(string password)
		{
			return PBKDF2.Hash(password).ToString();
		}

		public static int ConvertStringToInt(string text, int defaultValue)
		{
			bool checkNumber = int.TryParse(text, out int result);
			if (checkNumber)
			{
				return result;
			}
			else
			{
				return defaultValue;
			}
		}

		public static float ConvertStringToFloat(string text, float defaultValue)
		{
			bool checkNumber = float.TryParse(text, out float result);
			if (checkNumber)
			{
				return result;
			}
			else
			{
				return defaultValue;
			}
		}

		public static bool ComparePassword(string password, string passwordDB)
		{
			if (SignIn(password, passwordDB))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static String EncodeWildCard(String text, bool escapeQout = false)
		{
			text = text.Replace("\\", "\\\\").Replace("%", "\\%").Replace("_", "\\_");
			if (escapeQout)
			{
				text = text.Replace("'", "''");
			}
			return text;
		}

		public static int TotalPage(int totalUser, int limitRecord)
		{
			int totalPage;
			if (totalUser % limitRecord == 0)
			{
				totalPage = totalUser / limitRecord;
			}
			else
			{
				totalPage = (totalUser / limitRecord) + 1;
			}
			return totalPage;
		}

		public static List<int> GetListPaging(int page, int totalPage)
		{
			List<int> listPaging = new List<int>();
			int pageLimit = 3;
			int pageZone;
			if (page % pageLimit == 0)
			{
				pageZone = page / pageLimit;
			}
			else
			{
				pageZone = (page / pageLimit) + 1;
			}
			int firstPage = pageLimit * (pageZone - 1) + 1;
			int lastPage = firstPage + pageLimit - 1;
			if (lastPage > totalPage)
			{
				lastPage = totalPage;
			}
			for (int i = firstPage; i <= lastPage; i++)
			{
				listPaging.Add(i);
			}
			return listPaging;
		}

		public static int GetOffset(int page, int limitRecord)
		{
			int offSet = limitRecord * (page - 1);
			return offSet;
		}

		public static string GetMethodInfor()
		{
			StackTrace st = new StackTrace(true);
			MethodBase mb = st.GetFrame(1).GetMethod();
			return string.Format("{0}::{1}() ", mb.DeclaringType.FullName, mb.Name);
		}

		public static T GetObjectFromJson<T>(this ISession session, string key)
		{
			var value = session.GetString(key);
			return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
		}

		public static string CreatFileAudio(int userId, string type, IFormFile file)
		{
			string path = Path.Combine("Files", userId.ToString(), type);
			Directory.CreateDirectory(path);
			String fileName = string.Format("{0}.{1}", DateTime.Now.ToString("yyyyMMddHHmmssffff"), SubPathFile(file));
			string pathAudio = Path.Combine(path, fileName);
			FileStream stream = File.Create(pathAudio);
			stream.Close();
			return pathAudio;
		}

		public static string CreatFileImage(int userId, string type, List<IFormFile> fileList)
		{
			string pathAudioFile = string.Empty;
			FileStream stream = null;
			string dateTimeNow = DateTime.Now.ToString("yyyyMMddHHmmssffff");
			string path = Path.Combine("Files", userId.ToString(), type);
			Directory.CreateDirectory(path);
			int temp = 1;
			foreach (var file in fileList)
			{
				String fileName = string.Format("{0}-{1}.{2}", dateTimeNow, temp, SubPathFile(file));
				string pathAudio = Path.Combine(path, fileName);
				stream = File.Create(pathAudio);
				if (temp == 1)
				{
					pathAudioFile = pathAudio;
				}
				else
				{
					pathAudioFile = string.Format("{0}, {1}", pathAudioFile, pathAudio);
				}
				temp++;
				stream.Close();
			}
			return pathAudioFile;
		}

		public static void DeleteFile(string path)
		{
			string[] arrPath = path.Split(",");
			foreach (string item in arrPath)
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
				if (File.Exists(item.Trim()))
				{
					File.Delete(item.Trim());
				}
			}
		}

		private static string SubPathFile(IFormFile file)
		{
			string fileName = file.FileName;
			string[] arr = fileName.Split(".");
			return arr[arr.Length - 1];
		}
	}
}