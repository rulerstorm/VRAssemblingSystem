using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data;
using System;



public class SQLiteHelper {

    static string DatabaseName = "/testDatabase.db";

    static public string queryWithTableName(string tableName)
    {
        string conn = "URI=file:" + Application.dataPath + "/testDatabase.db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();

        string sqlQuery = "SELECT * FROM " + tableName;
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();

        string text = tableName + "的零件列表：\n";
        while (reader.Read())
        {
            //int ID = reader.GetInt32(0);
            text += reader.GetString(1) + '\n';
            //Debug.Log("ID= " + ID + "  name =" + name);
        }
  
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;

        //Debug.Log(text);

        return text;
    }


}
