using System;
using System.Collections.Generic;
using System.Linq;
using OopPractice.Document;

namespace OopPractice.DocumentStorage
{
  /// <summary>
  /// Хранилище-заглушка, имитрующее сохранение в файловой системе.
  /// </summary>
  internal sealed class FakeFileSystemStorage : IFileSystemStorage
  {
    #region Методы

    /// <summary>
    /// Найти документ или комплект документов.
    /// </summary>
    /// <param name="document">Документ/комплект.</param>
    /// <param name="name">Имя документа/комплекта.</param>
    /// <returns>Документ/комплект. Если не найден, то null.</returns>
    private IDocumentComponent? TryGetDocument(IDocumentComponent document, string name)
    {
      if (document.Name.Equals(name))
      {
        return document;
      }
      else
      {
        IEnumerable<IDocumentComponent> docs = document.Children;
        return docs.Select(doc => this.TryGetDocument(doc, name)).FirstOrDefault(found => found != null);
      }
    }

    #endregion

    #region IFileSystemStorage

    public void Save(IDocumentComponent document, string destDirFullPath)
    {
      IEnumerable<string> documentNames = document.GetFileNames();

      foreach (var name in documentNames)
      {
        IDocumentComponent? doc = this.TryGetDocument(document, name);

        if (doc != null)
          Console.WriteLine($"Файл {doc.Name} экспортирован в папку {destDirFullPath}.");
      }
    }

    #endregion
  }
}
