using LabeledData.Dao;
using LabeledData.Dao.Impl;
using LabeledData.Models;
using System.Collections.Generic;

namespace LabeledData.Services.Impl
{
	public class TblUserImpl : ITblUser
	{
		private ITblUserDao tblUserDao;

		public TblUserImpl()
		{
			tblUserDao = new TblUserDaoImpl();
		}

		public TblUserDto Login(string loginName, string password)
		{
			return tblUserDao.Login(loginName, password);
		}

		public TblUserDto ChangePassword(TblUserDto tblUserDto, string newPassword)
		{
			return tblUserDao.ChangePassword(tblUserDto, newPassword);
		}

		public bool CheckExistLoginName(string loginName, int userId)
		{
			return tblUserDao.CheckExistLoginName(loginName, userId);
		}

		public void InsertUser(TblUserDto tblUserDto)
		{
			tblUserDao.InsertUser(tblUserDto);
		}

		public int GetTotalUser(string username)
		{
			return tblUserDao.GetTotalUser(username);
		}

		public List<TblUserDto> GetAllUser(string username, int limitRecord, int offset)
		{
			return tblUserDao.GetAllUser(username, limitRecord, offset);
		}

		public TblUserDto GetUser(int userId)
		{
			return tblUserDao.GetUser(userId);
		}

		public void UpdateUser(TblUserDto tblUserDto)
		{
			tblUserDao.UpdateUser(tblUserDto);
		}

		public void DeleteUser(int userId)
		{
			tblUserDao.DeleteUser(userId);
		}
	}
}