// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CSVReader.cs" company="R&S">
// Copyright 2014  
// </copyright>
// <summary>
// The csv reader class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CSVReader
{
    using System;
    using System.IO;

    /// <summary>
    /// The CSV reader class
    /// </summary>
    public class CsvReader : IDisposable
    {
        /// <summary>
        /// The path
        /// </summary>
        private string path;

        /// <summary>
        /// The current data
        /// </summary>
        private string[] currentData;

        /// <summary>
        /// The reader
        /// </summary>
        private StreamReader reader;

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvReader"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <exception cref="System.InvalidOperationException">path does not exist</exception>
        public CsvReader(string path)
        {
            if (!File.Exists(path))
            {
                throw new InvalidOperationException("path does not exist");
            }

            this.path = path;
            this.Initialize();
        }

        /// <summary>
        /// Gets the data at the specified index.
        /// </summary>
        /// <value>The <see cref="System.String"/>.</value>
        /// <param name="index">The index.</param>
        /// <returns>The data as string</returns>
        public string this[int index]
        {
            get { return this.currentData[index]; }
        }

        /// <summary>
        /// Gets the data of the next line.
        /// </summary>
        /// <returns>The data of the next line.</returns>
        public bool Next()
        {
            string current = null;
            if ((current = this.reader.ReadLine()) == null)
            {
                return false;
            }

            this.currentData = current.Split(',');
            return true;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.reader.Close();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Initialize()
        {
            var stream = new FileStream(this.path, FileMode.Open, FileAccess.Read);
            this.reader = new StreamReader(stream);
        }
    }
}
