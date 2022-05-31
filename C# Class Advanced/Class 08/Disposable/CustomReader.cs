using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
{
    public class CustomReader : IDisposable
    {
        private readonly string _fileName;

        private readonly FileStream _stream;

        private bool _disposed = false;

        public CustomReader(string fileName)
        {
            _fileName = fileName;
            _stream = File.OpenRead(_fileName);
        }

        public string GetFileContent()
        {
            return _stream.ToString();
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _stream.Close();
                    _stream.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
