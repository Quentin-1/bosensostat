using System;
using SensoStatWeb.Business.Interfaces;

namespace SensoStatWeb.Business
{
    public class FileService : IFileService
    {
        public async Task<string> ReadCsvFile(Stream stream)
        {
            try
            {
                var reader = new StreamReader(stream);
                var content = reader.ReadToEndAsync();

                return await content;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }
    }
}

