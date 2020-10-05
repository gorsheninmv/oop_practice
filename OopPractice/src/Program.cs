using System;
using OopPractice.Document;
using OopPractice.DocumentStorage;

namespace OopPractice
{
  /// <summary>
  /// Класс точки входа в программу.
  /// </summary>
  internal sealed class Program
  {
    #region Константы

    /// <summary>
    /// Имя директории для сохранения документов.
    /// </summary>
    private const string DestinationDirectoryPath = @"C:\TEMP";

    #endregion

    #region Методы

    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    private static void Main(string[] args)
    {
      IRepository repo = new FakeRepository();
      IDocumentComponent doc = repo.Load();

      Console.WriteLine(doc.Description);

      IFileSystemStorage storage = new PackingDecorator(new EncryptingDecorator(new FakeFileSystemStorage()));
      storage.Save(doc, DestinationDirectoryPath);
    }
  }

  #endregion
}
