using Access.PostgresSQL;
using Access.Segurança;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access
{
    public static class PGAccess
    {
        private static string user1;

        private static string user2;

        public static string FriendlyName(this ColumnAttribute c)
        {
            if (c.Name == "")
                return string.Concat(c.Name.Select(x => Char.IsUpper(x) ? "_" + x : x.ToString())).TrimStart(' ').ToLower();
            else
                return c.Name;
        }
        /// <summary>
        /// Não usar este método !
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static bool SaveObject(object obj, NpgsqlConnection conn = null)
        {
            #region
            TableAttribute table = (TableAttribute)Attribute.GetCustomAttribute(obj.GetType(), typeof(TableAttribute));
            List<ColumnAttribute> colunas = new List<ColumnAttribute>();
            var props = obj.GetType().GetProperties().Where(n => n.CustomAttributes.ToList().Exists(v => v.AttributeType == typeof(ColumnAttribute)));
            var lCmd = new NpgsqlCommand();

            List<System.Reflection.PropertyInfo> keyProperty = new List<System.Reflection.PropertyInfo>();

            foreach (var p in props)
            {
                var col = (ColumnAttribute)Attribute.GetCustomAttribute(p, typeof(ColumnAttribute));
                if (p.CustomAttributes.ToList().Exists(n => n.AttributeType == typeof(KeyAttribute)))
                {
                    keyProperty.Add(p);
                }
                else
                    colunas.Add(col); // só adiciona as propriedadades que forem colunas, e nao sejam KEYAtribute
                var v = p.GetValue(obj);

                if (col.TypeName?.Length > 0)
                {
                    #region //Caso o tipo for Enum, converte para o tipo especificado
                    if (v is Enum)
                    {
                        if (col.TypeName == "Char")
                            v = (char)(int)v;
                        else if (col.TypeName == "Int" || col.TypeName == "Integer")
                            v = (int)v;

                        lCmd.Parameters.AddWithValue(col.Name, (NpgsqlTypes.NpgsqlDbType)Enum.Parse(typeof(NpgsqlTypes.NpgsqlDbType), col.TypeName), v);
                    }
                    #endregion //Caso o tipo for Enum, converte para o tipo especificado
                    else if (v is Array && col.TypeName.Equals("CharArray"))
                    {
                        lCmd.Parameters.AddWithValue(col.Name, (NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Char), v);
                    }
                }
                else
                    lCmd.Parameters.AddWithValue(col.Name, v);
            }

            long ID = 0;
            if (keyProperty.Count == 1)
                ID = Convert.ToInt64(keyProperty[0].GetValue(obj).ToString());
            else
                foreach (var p in keyProperty)
                    colunas.Add((ColumnAttribute)Attribute.GetCustomAttribute(p, typeof(ColumnAttribute)));

            string query = "";

            #region Monta a query
            if (keyProperty.Count == 1 && ID > 0)
            {
                query = "UPDATE " + (table.Schema.Length > 0 ? table.Schema + "." : "") + table.Name;
                query += " SET " + String.Join(", ", colunas.Select(n => n.Name + " =  @" + n.Name)) + " ";

                ColumnAttribute c = (ColumnAttribute)Attribute.GetCustomAttribute(keyProperty[0], typeof(ColumnAttribute));
                query += " WHERE " + c.Name + " =  @" + c.Name;
                query += ";";
            }
            else
            {
                query = "INSERT INTO " + (table.Schema.Length > 0 ? table.Schema + "." : "") + table.Name;
                query += " (" + String.Join(", ", colunas.Select(n => n.Name)) + ")";
                query += " VALUES (" + String.Join(", ", colunas.Select(n => "@" + n.Name)) + ")";

                //Verifica se existe uma propriedade que é chave primaria, e define para retornar o valor da chave ao ser inserido no banco de dados
                if (keyProperty.Count == 1)
                {
                    ColumnAttribute c = (ColumnAttribute)Attribute.GetCustomAttribute(keyProperty[0], typeof(ColumnAttribute));
                    query += " RETURNING " + c.Name;
                }
                else
                {
                    query += $" ON CONFLICT ({string.Join(",", keyProperty.Select(c => ((ColumnAttribute)Attribute.GetCustomAttribute(c, typeof(ColumnAttribute))).Name))}) DO UPDATE SET {string.Join(",", colunas.Select(c => c.Name + "=Excluded." + c.Name))}";
                }
                query += ";";
            }

            lCmd.CommandText = query;

            #endregion Monta a query

            lCmd.Connection = conn;

            try
            {
                if (keyProperty.Count > 1 || ID > 0)
                    ExecuteNonQuery(lCmd);
                else
                    keyProperty[0].SetValue(obj, ExecuteScalar(lCmd));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

            #endregion
        }
        /// <summary>
        /// Não usar este método !
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public static bool DeleteObject(object obj)
        {
            #region
            TableAttribute table = (TableAttribute)Attribute.GetCustomAttribute(obj.GetType(), typeof(TableAttribute));
            var props = obj.GetType().GetProperties().Where(n => n.CustomAttributes.ToList().Exists(v => v.AttributeType == typeof(ColumnAttribute)));
            var lCmd = new NpgsqlCommand();

            List<System.Reflection.PropertyInfo> keyProperty = new List<System.Reflection.PropertyInfo>();

            foreach (var p in props)
            {
                var col = (ColumnAttribute)Attribute.GetCustomAttribute(p, typeof(ColumnAttribute));
                if (p.CustomAttributes.ToList().Exists(n => n.AttributeType == typeof(KeyAttribute)))
                {
                    keyProperty.Add(p);
                    var v = p.GetValue(obj);

                    if (col.TypeName?.Length > 0)
                    {
                        #region //Caso o tipo for Enum, converte para o tipo especificado
                        if (v is Enum)
                        {
                            if (col.TypeName == "Char")
                                v = (char)(int)v;
                            else if (col.TypeName == "Int")
                                v = (int)v;
                        }
                        #endregion
                        lCmd.Parameters.AddWithValue(col.Name, (NpgsqlTypes.NpgsqlDbType)Enum.Parse(typeof(NpgsqlTypes.NpgsqlDbType), col.TypeName), v);
                    }
                    else
                        lCmd.Parameters.AddWithValue(col.Name, v);
                }
            }

            string query = "";

            #region Monta a query
            if (keyProperty.Count >= 1)
            {
                query = "DELETE FROM " + (table.Schema.Length > 0 ? table.Schema + "." : "") + table.Name;

                ColumnAttribute c = (ColumnAttribute)Attribute.GetCustomAttribute(keyProperty[0], typeof(ColumnAttribute));
                query += $" WHERE {(string.Join(" AND ", keyProperty.Select(k => ((ColumnAttribute)Attribute.GetCustomAttribute(k, typeof(ColumnAttribute))).Name + "=@" + ((ColumnAttribute)Attribute.GetCustomAttribute(k, typeof(ColumnAttribute))).Name)))}";
                query += ";";
            }

            lCmd.CommandText = query;

            #endregion

            try
            {
                if (keyProperty.Count >= 1)
                    ExecuteNonQuery(lCmd);

                return true;
            }
            catch
            {
                return false;
            }

            #endregion
        }

        public static List<T> GetListAllObjects<T>()
        {
            TableAttribute table = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));

            return GetListObjects<T>($"SELECT * FROM {((table.Schema.Length > 0 ? table.Schema + "." : "") + table.Name)};");
        }

        public static List<T> GetListObjects<T>(string command)
        {
            List<T> ret = new List<T>();
            NpgsqlCommand lCmd = new NpgsqlCommand(command);
            var rows = ExecuteReader(lCmd).Tables[0].Rows;
            TableAttribute table = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));
            if (table != null)
            {
                #region
                var props = typeof(T).GetProperties().Where(n => n.CustomAttributes.ToList().Exists(v => v.AttributeType == typeof(ColumnAttribute)));
                List<ColumnAttribute> colunas = new List<ColumnAttribute>();

                foreach (DataRow row in rows)
                {
                    var instance = (T)Activator.CreateInstance(typeof(T));
                    foreach (var p in props)
                    {
                        var col = (ColumnAttribute)Attribute.GetCustomAttribute(p, typeof(ColumnAttribute));
                        if (row[col.Name] != DBNull.Value)
                            p.SetValue(instance, row[col.Name]);
                    }
                    ret.Add(instance);
                }
                #endregion
            }
            else
                foreach (var row in rows) ret.Add((T)Activator.CreateInstance(typeof(T), row));

            return ret;
        }

        public static T GetObject<T>(string command)
        {
            return GetListObjects<T>(command).FirstOrDefault();
        }

        public static IDbConnection GetConnection()
        {
            string connectionString = $"User ID={Config.UserID};Password={Config.UserPassword};Host={Config.Host};Port={Config.Port};Database={Config.DBName};";

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            // conn.StateChange += Conn_StateChange;
            return conn;
        }

        public static void FinalizaSessoes(string banco, string applicationName = "")
        {
            try
            {
                string query = $"SELECT pg_terminate_backend(pid) FROM pg_stat_activity WHERE  pid <> pg_backend_pid() AND state like 'idle' AND datname = '{banco}' AND application_name = '{applicationName}'";
                PGAccess.ExecuteNonQuery(new NpgsqlCommand(query), false);
            }
            catch
            {
            }
        }

        public static IDbConnection GetConnectionBKP()
        {
            string connectionString = "Server=" + Config.IPServer + ";Port=" + Config.Port + ";User Id=" + Security.Cryption.Decrypt(user2) + ";Password=\"" + Security.Cryption.Decrypt(user1) + "\";Database=sysgestaobkp;Enlist=true;MinPoolSize=1;MaxPoolSize=" + Config.MaxPool.ToString() + ";CommandTimeout=40;" + $"ApplicationName = SysGestao-{ Environment.MachineName};";

            IDbConnection conn = new NpgsqlConnection(connectionString);
            return conn;
        }

        public static int ExecuteNonQuery(IDbCommand pCommand, bool registraLog = true)
        {
            bool retry = false;
            bool transaction = true;
            int rowsaffected = 0;
            do
            {
                if (retry && !transaction)
                    pCommand.Connection = null;

                if (pCommand.Connection == null)
                {
                    pCommand.Connection = GetConnection();
                    transaction = false;
                }
                try
                {
                    foreach (NpgsqlParameter parmt in pCommand.Parameters)
                        try
                        {
                            if (parmt.Value == null || parmt.Value.ToString() == char.MinValue.ToString())
                                parmt.Value = DBNull.Value;
                        }
                        catch { };

                    if (pCommand.Connection.State == ConnectionState.Closed)
                    {
                        transaction = false;
                        pCommand.Connection.Open();
                    }

                    rowsaffected = pCommand.ExecuteNonQuery();

                    if (retry)
                        retry = false;
                    /*
                    #region Criando Log Auditoria
                    if (registraLog)
                    {
                        InsereLogAuditoria(pCommand);
                    }
                    #endregion
                    */
                }
                catch (NpgsqlException ex)
                {
                    /*
                    #region Criando Log Auditoria
                    InsereLogAuditoria(pCommand, ex.Message.ToString());
                    #endregion
                    */

                    // NetworkLog.Insert(ex, pCommand.CommandText);
                    if (ex.Message.Contains("Exception while writing to stream") || ex.Message.Contains("Exception while reading from stream"))
                    {
                        if (!retry)
                            retry = true;
                        else
                        {
                            MessageBox.Show("Atenção! Houve perda de conexão com o servidor ou ele demorou muito a responder." + (ex.InnerException != null ? "\r\n\r\nDetalhamento do erro: " + ex.InnerException.Message : "") + "\r\n\r\nÉ possível que as últimas alterações não foram salvas, por favor verifique.", "1) " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            retry = false;
                        }
                        //Application.Exit(new CancelEventArgs(true));
                    }
                    else if (ex.Data["Code"]?.ToString().CompareTo("08P01") == 0)
                        MessageBox.Show("Atenção! Erro ao executar o comando:\r\n\r\n" + pCommand.CommandText + "", "Violação de protocolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        TrataExcecao(ex, (NpgsqlCommand)pCommand);

                    if (transaction)
                        throw ex;
                }
                finally
                {
                    if (pCommand.Connection.State == ConnectionState.Open && !transaction)
                    {
                        pCommand.Connection.Close();
                    }
                }
            } while (retry);
            return rowsaffected;
        }       

        public static T ExecuteScalar<T>(string command)
        {
            var cmd = new NpgsqlCommand(command);
            var obj = ExecuteScalar(cmd);

            return (T)obj;
        }

        public static object ExecuteScalar(string command)
        {
            var cmd = new NpgsqlCommand(command);
            var obj = ExecuteScalar(cmd);

            return obj;
        }

        public static Object ExecuteScalar(IDbCommand pCommand, bool registraLog = true)
        {
            bool retry = false;
            bool transaction = true;
            Object aux = null;

            do
            {
                if (retry && !transaction)
                    pCommand.Connection = null;

                if (pCommand.Connection == null)
                {
                    pCommand.Connection = GetConnection();
                    transaction = false;
                }
                try
                {
                    foreach (NpgsqlParameter parmt in pCommand.Parameters)
                        try
                        {
                            if (parmt.Value == null || parmt.Value.ToString() == char.MinValue.ToString())
                                parmt.Value = DBNull.Value;
                        }
                        catch { };

                    if (pCommand.Connection.State == ConnectionState.Closed)
                    {
                        transaction = false;
                        pCommand.Connection.Open();
                    }

                    aux = pCommand.ExecuteScalar();
                    if (retry)
                        retry = false;
                    /*
                    #region Criando Log Auditoria
                        if (registraLog)
                        {
                            InsereLogAuditoria(pCommand);
                        }
                    #endregion
                    */
                }
                catch (NpgsqlException ex)
                {
                    /*
                    #region Registra Log Auditoria
                    InsereLogAuditoria(pCommand, ex.Message.ToString());
                    #endregion
                    */
                    var paramsds = "";
                    foreach (NpgsqlParameter p in pCommand.Parameters)
                        paramsds += p.Value;

                    //NetworkLog.Insert(ex, pCommand.CommandText);

                    if (ex.Message.Contains("Exception while writing to stream") || ex.Message.Contains("Exception while reading from stream"))
                    {
                        if (!retry)
                            retry = true;
                        else
                        {
                            MessageBox.Show("Atenção! Houve perda de conexão com o servidor ou ele demorou muito a responder." + (ex.InnerException != null ? "\r\n\r\nDetalhamento do erro: " + ex.InnerException.Message : "") + "\r\n\r\nÉ possível que as últimas alterações não foram salvas, por favor verifique.", "3) " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            retry = false;
                        }
                        //Application.Exit(new CancelEventArgs(true));
                    }
                    else if (ex.Data["Code"]?.ToString().CompareTo("08P01") == 0)
                        MessageBox.Show("Atenção! Erro ao executar o comando:\r\n\r\n" + pCommand.CommandText + "", "Violação de protocolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        TrataExcecao(ex, (NpgsqlCommand)pCommand);
                    if (transaction)
                        throw ex;
                    return null;
                }
                finally
                {
                    if (pCommand.Connection.State == ConnectionState.Open && !transaction)
                    {
                        pCommand.Connection.Close();
                    }
                }
            } while (retry);
            return aux;
        }

        public static DataSet ExecuteReader(IDbCommand pCommand)
        {
            bool retry = false;
            DataSet ds = null;
            bool transaction = true;
            do
            {
                // Caso  seja retry, se não recriar a connection vai SEMPRE ocorrer Exception while writing/readig to stream", porém quando é transaction, não pode remover a connection
                if (retry && !transaction)
                    pCommand.Connection = null;

                if (pCommand.Connection == null)
                {
                    pCommand.Connection = GetConnection();
                    transaction = false;
                }

                try
                {
                    foreach (NpgsqlParameter parmt in pCommand.Parameters)
                        try
                        {
                            if (parmt.Value == null || parmt.Value.ToString() == char.MinValue.ToString())
                                parmt.Value = DBNull.Value;
                        }
                        catch { };

                    if (pCommand.Connection.State == ConnectionState.Closed)
                    {
                        pCommand.Connection.Open();
                        transaction = false;
                    }

                    //pCommand.Connection.Open();

                    IDbDataAdapter da = new NpgsqlDataAdapter((NpgsqlCommand)pCommand);

                    ds = new DataSet();

                    da.Fill(ds);

                    //Caso não dê mais erro, remove o retry
                    if (retry)
                        retry = false;
                }
                catch (NpgsqlException ex)
                {
                    // NetworkLog.Insert(ex, pCommand.CommandText);
                    if (ex.Message.Contains("Exception while writing to stream") || ex.Message.Contains("Exception while reading from stream"))
                    {
                        if (!retry)
                            retry = true;
                        else
                        {
                            MessageBox.Show("Atenção! Houve perda de conexão com o servidor ou ele demorou muito a responder." + (ex.InnerException != null ? "\r\n\r\nDetalhamento do erro: " + ex.InnerException.Message : "") + "\r\n\r\nÉ possível que as últimas alterações não foram salvas, por favor verifique.", "4) " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            retry = false;
                        }

                        //Application.Exit(new CancelEventArgs(true));
                    }
                    else if (ex.Data["Code"]?.ToString().CompareTo("08P01") == 0)
                        MessageBox.Show("Atenção! Erro ao executar o comando:\r\n\r\n" + pCommand.CommandText + "", "Violação de protocolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        TrataExcecao(ex, (NpgsqlCommand)pCommand);
                }
                finally
                {
                    if (pCommand.Connection.State == ConnectionState.Open && !transaction)
                    {
                        pCommand.Connection.Close();
                    }
                }
            } while (retry);

            return ds;
        }

        public static DataSet ExecuteReaderBKP(IDbCommand pCommand)
        {
            bool retry = false;
            DataSet ds = null;

            do
            {
                if (retry)
                    pCommand.Connection = null;

                bool transaction = true;

                if (pCommand.Connection == null)
                {
                    pCommand.Connection = GetConnectionBKP();
                    transaction = false;
                }

                try
                {
                    foreach (NpgsqlParameter parmt in pCommand.Parameters)
                        try
                        {
                            if (parmt.Value == null || parmt.Value.ToString() == char.MinValue.ToString())
                                parmt.Value = DBNull.Value;
                        }
                        catch { };

                    if (pCommand.Connection.State == ConnectionState.Closed)
                    {
                        pCommand.Connection.Open();
                        transaction = false;
                    }

                    //pCommand.Connection.Open();

                    IDbDataAdapter da = new NpgsqlDataAdapter((NpgsqlCommand)pCommand);

                    ds = new DataSet();

                    da.Fill(ds);

                    if (retry)
                        retry = false;
                }
                catch (NpgsqlException ex)
                {
                    //  NetworkLog.Insert(ex, pCommand.CommandText);
                    if (ex.Message.Contains("Exception while writing to stream") || ex.Message.Contains("Exception while reading from stream"))
                    {
                        if (!retry)
                        {
                            //MessageBox.Show("Atenção! Houve perda de conexão com o servidor ou ele demorou muito a responder." + (ex.InnerException != null ? "\r\n\r\nDetalhamento do erro: " + ex.InnerException.Message : "") + "\r\n\r\nÉ possível que as últimas alterações não foram salvas, por favor verifique.", "4) " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            retry = true;
                        }
                        else
                            retry = false;

                        //Application.Exit(new CancelEventArgs(true));
                    }
                    else if (ex.Data["Code"]?.ToString().CompareTo("08P01") == 0)
                        MessageBox.Show("Atenção! Erro ao executar o comando:\r\n\r\n" + pCommand.CommandText + "", "Violação de protocolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        TrataExcecao(ex, (NpgsqlCommand)pCommand);
                }
                finally
                {
                    if (pCommand.Connection.State == ConnectionState.Open && !transaction)
                    {
                        pCommand.Connection.Close();
                    }
                }
            } while (retry);

            return ds;
        }

        public static void TrataExcecao(NpgsqlException excecao, NpgsqlCommand Comando)
        {
            string detalhes = "";
            if (Comando.Parameters == null || Comando.Parameters.Count == 0)
                detalhes = "Comando:" + Comando.CommandText;
            else
            {
                detalhes = "Parâmetros:";
                foreach (NpgsqlParameter param in Comando.Parameters)
                    if (param.Value != null)
                        detalhes += param.Value.ToString() + ", ";
                detalhes = detalhes.Substring(0, detalhes.Length - 2) + ".";
            }
            switch (excecao.Data["Code"]?.ToString())
            {
                case "":
                    MessageBox.Show("Falha ao estabelecer conexão com o servidor (" + Config.IPServer + "). Verifique:\r\n\r\n* O endereço IP do servidor está correto?\r\n* Porta 5432 no firewall do servidor está desbloqueada?\r\n* As configurações do servidor PostgreSQL estão corretas?", "Falha ao estabelecer conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "28000":
                    MessageBox.Show("Atenção! O nome do usuário e/ou a senha são inválidos. Tente novamente. ", "Erro ao entrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "25P02":
                    MessageBox.Show("Atenção! A transação atual foi abortada e os dados podem não ter sido salvos completamente. Motivo: " + excecao.Message + " \r\n\r\n" + detalhes, "Transação abortada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "22P05":
                    MessageBox.Show("Atenção! Caractere inválido encontrado.\r\nErro:" + excecao.Message + "\r\n\r\n" + detalhes, "Erro ao inserir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "28P01":
                    MessageBox.Show("Atenção! O nome do usuário e/ou a senha são inválidos. Tente novamente.", "Erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "23505":
                    MessageBox.Show("Atenção! Não foi possível incluir os dados atuais.\r\nFoi retornado um erro de chave duplicada. Por favor, reinicie o SysGestao e tente novamente.\r\n\r\nCaso o problema persista entre em contato com nosso Suporte Técnico.", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;

                default:
                    MessageBox.Show(excecao.Data["Code"]?.ToString() + ": " + excecao.Message + "\r\n\r\n" + detalhes, "Erro no banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;
            }
        }


        public static string Encrypt(string user, string pass)
        {
            string EncryptionKey = user + "stv4!@#";
            byte[] clearBytes = Encoding.Unicode.GetBytes(pass);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    pass = Convert.ToBase64String(ms.ToArray());
                }
            }
            return pass;
        }

        public static string Decrypt(string user, string pass)
        {
            string EncryptionKey = user + "stv4!@#";
            //pass = pass.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(pass);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    pass = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return pass;
        }   
    }
}
