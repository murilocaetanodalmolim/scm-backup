﻿using System;
using System.IO;
using System.Linq;

namespace ScmBackup
{
    /// <summary>
    /// helper class for file system operations
    /// </summary>
    public class FileSystemHelper : IFileSystemHelper
    {
        /// <summary>
        /// Checks whether the given directory is empty
        /// </summary>
        public bool DirectoryIsEmpty(string path)
        {
            if (Directory.GetFiles(path).Any() || Directory.GetDirectories(path).Any())
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Creates a subdirectory inside the given directory and returns the path
        /// </summary>
        public string CreateSubDirectory(string mainDir, string subDir)
        {
            if (!Directory.Exists(mainDir))
            {
                throw new DirectoryNotFoundException(string.Format("Directory {0} doesn't exist!", mainDir));
            }

            string newDir = Path.Combine(mainDir, subDir);
            Directory.CreateDirectory(newDir);
            return newDir;
        }
    }
}
