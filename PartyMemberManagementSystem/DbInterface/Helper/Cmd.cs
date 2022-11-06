using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

//using System.Data.SqlClient;
using System.Data.OleDb;
//using MySql.Data.MySqlClient;
using System.Drawing;

public class Cmd
{

    public static string ConnectionString = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=|DataDirectory|\\PMMS.accdb;";
    //"server=localhost;uid=root;database=ces_sale_system;Charset=utf8;";  //"server=.;uid=sa;pwd=123;database=TestDb2;";


    static OleDbConnection cn = null;
    static OleDbCommand cmd = null;
    static OleDbDataAdapter da = null;
    public static OleDbTransaction tran = null;
    static string lastCmd = "";

    public static Dictionary<string, object> Parameters = new Dictionary<string, object>();
    public static OleDbCommand Command(string sql, params object[] args)
    {
        for (int i = 0; i <= args.Length - 1; i++)
        {
            sql = sql.Replace("{" + i + "}", "@P" + i);
            Parameters["@P" + i] = args[i];
        }

        cmd = new OleDbCommand(sql);
        cmd.Connection = connection();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = sql;

        if ((tran != null))
        {
            cmd.Transaction = tran;
        }

        foreach (KeyValuePair<string, object> p in Parameters)
        {
            if (p.Value is DateTime)
            {
                cmd.Parameters.Add(p.Key, OleDbType.Date).Value = p.Value;
            }
            else if (p.Value is long || p.Value is int)
            {
                cmd.Parameters.Add(p.Key, OleDbType.SmallInt).Value = p.Value;
            }
            else if (p.Value is double || p.Value is decimal || p.Value is float)
            {
                cmd.Parameters.Add(p.Key, OleDbType.Decimal).Value = p.Value;
            }
            else if (p.Value is bool)
            {
                cmd.Parameters.Add(p.Key, OleDbType.Boolean).Value = p.Value;
            }
            else if (p.Value == null || object.ReferenceEquals(p.Value, DBNull.Value))
            {
                cmd.CommandText = cmd.CommandText.Replace(p.Key, "null");
            }
            else if (p.Value is byte[])
            {
                cmd.Parameters.Add(p.Key, OleDbType.LongVarBinary).Value = p.Value;
            }
            else
            {
                cmd.Parameters.Add(p.Key, OleDbType.VarWChar).Value = p.Value;
            }
        }

        lastCmd = cmd.CommandText;

        Parameters.Clear();

        return cmd;
    }

    public static OleDbConnection connection()
    {
        try
        {
            if (cn == null)
            {
                cn = new OleDbConnection(ConnectionString);
            }
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            return cn;
        }
        catch (OleDbException generatedExceptionName)
        {
            cn = new OleDbConnection(ConnectionString);
            cn.Open();
            return cn;
        }
    }


    public static object ExecuteScalar(string sql, params object[] values)
    {
        return Command(sql, values).ExecuteScalar();
    }

    public static int ExecuteNonQuery(string sql, params object[] values)
    {
        return Command(sql, values).ExecuteNonQuery();
    }

    public static DataTable ExecuteDataTable(string sql, params object[] values)
    {
        if (da == null)
        {
            da = new OleDbDataAdapter();
        }
        da.SelectCommand = Command(sql, values);
        DataTable dt = new DataTable();
    da.Fill(dt);
        return dt;
    }


    public static IDataReader ExecuteDataReader(string sql, params object[] values)
    {
        return Command(sql, values).ExecuteReader();
    }

    public static DataSet ExecuteDataSet(string sql, params object[] values)
    {
        if (da == null)
        {
            da = new OleDbDataAdapter();
        }
        da.SelectCommand = Command(sql, values);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public static void Begin()
    {
        if (tran == null)
        {
            tran = connection().BeginTransaction();
            if (cmd == null)
            {
                cmd = connection().CreateCommand();
            }
            cmd.Transaction = tran;
        }
    }
    public static void Commit()
    {
        tran.Commit();
        tran = null;
    }
    public static void Rollback()
    {
        tran.Rollback();
        tran = null;
    }
    public static OleDbTransaction Trans
    {
        get { return tran; }
    }
}