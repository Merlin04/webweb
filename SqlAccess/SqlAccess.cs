using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Data;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SqlAccess
{
    public class SqlAccess
    {
        public string GetConnectionString()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);

            IConfigurationRoot configuration = builder.Build();
            // configurationSection.Key => FilePath
            // configurationSection.Value => C:\\temp\\logs\\output.txt
            return configuration.GetSection("ConnectionStrings")["DefaultConnection"];
        }

        /// <summary>
        /// Gets an array containing the html, css, and js of a page by its name.
        /// </summary>
        /// <returns>Array of strings: [html, css, js].</returns>
        /// <param name="pageName">Page name.</param>
        public string[] GetPageByName(string pageName)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("Select page_html from Pages where page_name=@page_name", scn);
            cmd.Parameters.AddWithValue("@page_name", pageName);
            SQLiteCommand cmd2 = new SQLiteCommand("Select page_css from Pages where page_name=@page_name", scn);
            cmd2.Parameters.AddWithValue("@page_name", pageName);
            SQLiteCommand cmd3 = new SQLiteCommand("Select page_js from Pages where page_name=@page_name", scn);
            cmd3.Parameters.AddWithValue("@page_name", pageName);
            SQLiteCommand cmd4 = new SQLiteCommand("Select page_head from Pages where page_name=@page_name", scn);
            cmd4.Parameters.AddWithValue("@page_name", pageName);
            try
            {
                scn.Open();
                string[] ret = { Convert.ToString(cmd.ExecuteScalar()), Convert.ToString(cmd2.ExecuteScalar()), Convert.ToString(cmd3.ExecuteScalar()), Convert.ToString(cmd4.ExecuteScalar()) };
                scn.Close();
                return ret;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != System.Data.ConnectionState.Closed)
                    {
                        scn.Close();
                    }
                    scn.Dispose();
                }
            }
        }

        public string FixNameCaps(string pageName)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("Select page_name from Pages where page_name=@page_name", scn);
            cmd.Parameters.AddWithValue("@page_name", pageName);
            try
            {
                scn.Open();
                string ret = Convert.ToString(cmd.ExecuteScalar());
                scn.Close();
                return ret;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != System.Data.ConnectionState.Closed)
                    {
                        scn.Close();
                    }
                    scn.Dispose();
                }
            }
        }

        public string FixNameCapsTemplate(string templateId)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("Select name from Templates where id=@id", scn);
            cmd.Parameters.AddWithValue("@id", templateId);
            try
            {
                scn.Open();
                string ret = Convert.ToString(cmd.ExecuteScalar());
                scn.Close();
                return ret;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != System.Data.ConnectionState.Closed)
                    {
                        scn.Close();
                    }
                    scn.Dispose();
                }
            }
        }

        public DataSet GetTemplates()
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("select * from Templates", scn);

            try
            {
                scn.Open();

                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                scn.Close();
                return ds;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }

        public DataSet GetTemplateByName(string templateName)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("select * from Templates where name=@name", scn);
            cmd.Parameters.AddWithValue("@name", templateName);
            try
            {
                scn.Open();

                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                scn.Close();
                return ds;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }

        public DataSet GetTemplateById(string templateId)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("select * from Templates where id=@id", scn);
            cmd.Parameters.AddWithValue("@id", templateId);
            try
            {
                scn.Open();

                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                scn.Close();
                return ds;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }

        public DataSet GetAllTemplates()
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("select * from Templates", scn);
            try
            {
                scn.Open();

                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                scn.Close();
                return ds;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }

        public string NewTemplate(string templateName)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("insert into Templates (name) values(@templateName); select last_insert_rowid();", scn);
            cmd.Parameters.AddWithValue("@templateName", templateName);
            try
            {
                scn.Open();
                string ret = Convert.ToString(cmd.ExecuteScalar());
                scn.Close();
                return ret;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != System.Data.ConnectionState.Closed)
                    {
                        scn.Close();
                    }
                    scn.Dispose();
                }
            }
        }

        public void NewPage(string pageName, string pageHtml, string pageCss, string pageJs, string pageHead = null)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("insert into Pages (page_name, page_html, page_css, page_js, page_head, is_staging) values(@page_name, @page_html, @page_css, @page_js, @page_head, @is_staging)", scn);
            cmd.Parameters.AddWithValue("@page_name", pageName);
            cmd.Parameters.AddWithValue("@page_html", pageHtml);
            cmd.Parameters.AddWithValue("@page_css", pageCss ?? "");
            cmd.Parameters.AddWithValue("@page_js", pageJs ?? "");
            cmd.Parameters.AddWithValue("@page_head", pageHead ?? "");
            try
            {
                cmd.Parameters.AddWithValue("@is_staging", (pageName.Substring(0, 6) == "Draft|"));
            }
            catch(Exception ex)
            {
                cmd.Parameters.AddWithValue("@is_staging", false);
            }
            try
            {
                scn.Open();
                // Make sure that the connection works before deleting page. 
                DeletePage(pageName);
                cmd.ExecuteNonQuery();
                scn.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }

        public void DeletePage(string pageName)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("delete from Pages where page_name=@page_name", scn);
            cmd.Parameters.AddWithValue("@page_name", pageName);

            try
            {
                scn.Open();
                cmd.ExecuteNonQuery();
                scn.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }

        public void DeleteTemplate(string templateId)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("delete from Templates where id=@id", scn);
            cmd.Parameters.AddWithValue("@id", templateId);

            try
            {
                scn.Open();
                cmd.ExecuteNonQuery();
                scn.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }

        public void EditTemplate(string templateId, string templateName, string templateDesc, string pageHtml, string pageCss, string pageJs, string pageHead)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("update Templates set name=@name, description=@description, contents_html=@contents_html, contents_css=@contents_css, contents_js=@contents_js, contents_head=@contents_head where id=@id", scn);
            cmd.Parameters.AddWithValue("@id", templateId);
            cmd.Parameters.AddWithValue("@name", templateName);
            cmd.Parameters.AddWithValue("@description", templateDesc);
            cmd.Parameters.AddWithValue("@contents_html", pageHtml);
            cmd.Parameters.AddWithValue("@contents_css", pageCss);
            cmd.Parameters.AddWithValue("@contents_js", pageJs);
            cmd.Parameters.AddWithValue("@contents_head", pageHead);

            try
            {
                scn.Open();
                cmd.ExecuteNonQuery();
                scn.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }

        public void CreateEmptyPage(string pageName)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("insert into Pages (page_name, is_staging) values(@page_name, @is_staging)", scn);
            cmd.Parameters.AddWithValue("@page_name", pageName);
            cmd.Parameters.AddWithValue("@is_staging", 1);

            try
            {
                scn.Open();
                cmd.ExecuteNonQuery();
                scn.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }
        
        public string AddRegisterToken(string token, DateTime expire)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("insert into RegisterTokens (Token, Expire) values(@Token, @Expire)", scn);
            cmd.Parameters.AddWithValue("@Token", token);
            cmd.Parameters.AddWithValue("@Expire", expire);

            try
            {
                scn.Open();
                cmd.ExecuteNonQuery();
                scn.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }

            return token;
        }

        /// <summary>
        /// Check if a register token is valid.
        /// </summary>
        /// <param name="token">The token to check.</param>
        /// <returns>True if it is valid, false otherwise</returns>
        public bool CheckRegisterToken(string token)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("select Expire from RegisterTokens where Token = @Token", scn);
            cmd.Parameters.AddWithValue("@Token", token);
            DateTime expireTime;
            
            try
            {
                scn.Open();
                expireTime = (DateTime)cmd.ExecuteScalar();
                scn.Close();
            }
            catch (Exception er)
            {
                return false;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }

            return (DateTime.Now < expireTime);
        }

        public void DeleteRegisterToken(string token)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("delete from RegisterTokens where Token = @Token", scn);
            cmd.Parameters.AddWithValue("@Token", token);

            try
            {
                scn.Open();
                cmd.ExecuteNonQuery();
                scn.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }
        
        public DataSet RunSqlQuery(string query)
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand(query, scn);

            try
            {
                scn.Open();
                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                scn.Close();
                return ds;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }

        public bool IsDBSetup()
        {
            string result = string.Empty;
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("select name from sqlite_master where type='table' and name='Pages';", scn);

            try
            {
                scn.Open(); 
                result = cmd.ExecuteScalar().ToString();
                scn.Close();
            }
            catch (Exception er)
            {
                //throw er;
                return false;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }

            if (result == "Pages")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void SetupDB()
        {
            SQLiteConnection scn = new SQLiteConnection(GetConnectionString());
            SQLiteCommand cmd = new SQLiteCommand("create table Pages (\r\n    id integer primary key autoincrement not null,\r\n    page_name varchar(100),\r\n    page_html TEXT,\r\n    last_update DATETIME default CURRENT_TIMESTAMP,\r\n    is_staging BIT,\r\n    page_css TEXT,\r\n    page_js TEXT,\r\n    page_head TEXT\r\n);\r\ncreate table Templates (\r\n    id integer primary key autoincrement not null,\r\n    name varchar(200),\r\n    description TEXT,\r\n    contents_html TEXT,\r\n    contents_css TEXT,\r\n    contents_js TEXT,\r\n    contents_head TEXT\r\n);\r\ncreate table RegisterTokens (\r\n    Token varchar(255),\r\n    Expire datetime\r\n);\r\ninsert into Pages (page_name, page_html, is_staging, page_css, page_js) values(\r\n'Index',\r\n'<h1>Welcome to your new website!</h1>\r\n<p>To get started, click the edit button in the navigation bar.</p>',\r\n0,\r\n'/*Looks like you were able to get to the edit page. Try typing in some CSS!*/\r\n.customContent {}',\r\n'// You can add JavaScript too\r\n$( document ).ready(function() {});');\r\ninsert into Templates (name, description, contents_html, contents_css, contents_js) values(\r\n'Default page',\r\n'A plain page template with a title and a space for page contents.',\r\n'<div class=\"ui header\">{{PAGENAME}}</div>\r\n<div id=\"page-content\">\r\n    This is where your page content should go.\r\n</div>',\r\n'',\r\n''\r\n)", scn);

            try
            {
                scn.Open();
                cmd.ExecuteNonQuery();
                scn.Close();
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                if (scn != null)
                {
                    if (scn.State != ConnectionState.Closed)
                        scn.Close();
                    scn.Dispose();
                }
            }
        }
    }
}
