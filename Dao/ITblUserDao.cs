using LabeledData.Models;
using System.Collections.Generic;

namespace LabeledData.Dao
{
	public interface ITblUserDao
	{
		TblUserDto Login(string loginName, string password);
		TblUserDto ChangePassword(TblUserDto tblUserDto, string newPassword);
		bool CheckExistLoginName(string loginName, int userId);
		void InsertUser(TblUserDto tblUserDto);
		int GetTotalUser(string username);
		List<TblUserDto> GetAllUser(string username, int limitRecord, int offset);
		TblUserDto GetUser(int userId);
		void UpdateUser(TblUserDto tblUserDto);
		void DeleteUser(int userId);
	}
}
