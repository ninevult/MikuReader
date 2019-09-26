﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikuReader.Core
{
    /// <summary>
    /// Represents a Title
    /// </summary>
    public abstract class Title
    {
        /// <summary>
        /// Update the user's location in this Title
        /// </summary>
        /// <param name="chapter">User's current Chapter</param>
        /// <param name="page">User's current Page</param>
        public abstract void UpdateLocation(string chapter, string page);

        /// <summary>
        /// Get the name of the title
        /// </summary>
        /// <returns>The name of this Title</returns>
        public abstract string GetTitle();

        /// <summary>
        /// Get the user-specified nickname for the manga
        /// </summary>
        /// <returns>The User-specified override title</returns>
        public abstract string GetUserTitle();

        /// <summary>
        /// Get the Type of a Title
        /// </summary>
        /// <param name="dir">Title's directory</param>
        /// <returns></returns>
        public static TitleType GetType(DirectoryInfo dir)
        {
            switch (File.ReadAllLines(FileHelper.GetFilePath(dir, "manga.txt"))[0])
            {
                case "manga":
                    return TitleType.MANGA;
                default:
                    return TitleType.NULL;
            }
        }
    }
}