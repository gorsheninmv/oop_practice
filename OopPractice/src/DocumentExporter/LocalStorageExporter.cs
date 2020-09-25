using System;
using System.Collections.Generic;
using OopPractice.Document;

namespace OopPractice.DocumentExporter
{
  /// <summary>
  /// Класс, инкапсулирующий экспорт документов на диск.
  /// </summary>
  internal sealed class LocalStorageExporter : IExporter
  {
    /// <summary>
    /// Экспортировать документы.
    /// </summary>
    /// <param name="docs">Документ / набор документов.</param>
    /// <param name="destDirFullPath">Полный путь директории для экспорта.</param>
    public void Export(IDocumentComponent docs, string destDirFullPath)
    {
      IEnumerable<string> fileNames = docs.GetFileNames();

      foreach (var fileName in fileNames)
      {
        IDocumentComponent doc = docs.TryFind(fileName);

        if (doc != null)
          Console.WriteLine($"Файл {doc.Name} экспортирован в папку {destDirFullPath}.");
      }
    }
  }
}
