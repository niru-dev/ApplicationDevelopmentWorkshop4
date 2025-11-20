using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public class AppSettings
    {
        private string? _connectionString;
        private int _maxConnections = 10;

        public string? ConnectionString
        {
            get => _connectionString;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Connection string cannot be empty.", nameof(value));
                _connectionString = value;
            }
        }

        public int MaxConnections
        {
            get => _maxConnections;
            set
            {
                if (value <= 0 || value > 1000) throw new ArgumentOutOfRangeException(nameof(value), "MaxConnections must be between1 and1000.");
                _maxConnections = value;
            }
        }
    }
}