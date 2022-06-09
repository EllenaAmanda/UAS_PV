/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/06/2022
 * Time: 17.08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace UAS_PV
{
	/// <summary>
	/// Description of Koneksi.
	/// </summary>
	class Koneksi
	{
		public SqlConnection GetConn()
		{
			SqlConnection Conn = new SqlConnection();
			Conn.ConnectionString = "Data Source=DESKTOP-DRJE9BF\\SQLEXPRESS; initial catalog=uas_pv; integrated security=true;";
			return Conn;
		}
	}
}
