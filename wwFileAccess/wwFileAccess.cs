using System;
using System.Data;
using System.IO;
using System.Web;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace wwFileAccess
{
    public class wwFileAccess
    {
        public string[] GetAllFiles()
        {
            string[] outputList = Directory.GetFiles(MapPath("~/wwwroot/Content/resources"));
            for (int i = 0; i < outputList.Length; i++)
            {
                outputList[i] = "/Content/resources/" + outputList[i].Split('/').Last();
            }
            return outputList;
        }

        /// <summary>
        /// Moves a file from oldName to newName.
        /// </summary>
        /// <returns><c>true</c>, if file was successfully moved, <c>false</c> otherwise.</returns>
        /// <param name="oldName">Old path, starting with /Content/resources.</param>
        /// <param name="newName">New file name.</param>
        public bool MoveFile(string oldName, string newName)
        {
            if (oldName.Contains("..") || newName.Contains(".."))
            {
                // Don't let anyone access files outside of resources. 
                return false;
            }
            try
            {
                string oldPath = MapPath("~/wwwroot" + oldName);
                string newPath = MapPath("~/wwwroot/Content/resources/" + newName);
                System.IO.File.Move(oldPath, newPath);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Garbages the file.
        /// </summary>
        /// <returns><c>true</c>, if file was garbaged, <c>false</c> otherwise.</returns>
        /// <param name="filePath">File path, starting with /Content/resources.</param>
        public bool GarbageFile(string filePath)
        {
            if (filePath.Contains(".."))
            {
                // Don't let anyone access files outside of resources. 
                return false;
            }
            try
            {
                string oldPath = MapPath("~/wwwroot" + filePath);
                string newPath = MapPath("~/wwwroot/Content/garbage/" + filePath.Split('/').Last());
                System.IO.File.Move(oldPath, newPath);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string MapPath(string path)
        {
            string newPath = path;
            if(newPath[0] == '/')
            {
                newPath = newPath.Substring(1);
            }
            return Path.GetFullPath(newPath.Replace("~/", "")).Replace("~\\", "");
        }
    }
}
