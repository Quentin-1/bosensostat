using System;

namespace SensoStatWeb.Business.Interfaces
{
    public interface IFileService
    {
        Task<string> ReadCsvFile(Stream stream);
    }
}

