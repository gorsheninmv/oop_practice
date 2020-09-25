using System;
using OopPractice.Document;
using OopPractice.DocumentExporter;

namespace OopPractice
{
  /// <summary>
  /// Класс точки входа в программу.
  /// </summary>
  internal sealed class Program
  {
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    private static void Main(string[] args)
    {
      IDocumentComponent docs = GetDocsFromRepo();
      IExporter exporter = GetExporter();

      exporter.Export(docs, @"C:\TEMP");

      Console.WriteLine(new string('=', 10));
      Console.WriteLine(docs.Description);
    }

    /// <summary>
    /// Получить документы из репозитория.
    /// </summary>
    /// <returns>Документ/комплект.</returns>
    private static IDocumentComponent GetDocsFromRepo()
    {
      var doc1 = new DocumentComponent("Документ 1");
      var doc2 = new DocumentComponent("Документ 2");
      var comp1 = new DocumentComposite("Комплект 1");
      comp1.Add(doc1);
      comp1.Add(doc2);
      var doc3 = new DocumentComponent("Документ 3");
      var comp2 = new DocumentComposite("Комплект 2");
      comp2.Add(doc3);
      comp2.Add(comp1);

      return comp2;
    }

    /// <summary>
    /// Получить объект-экспортер.
    /// </summary>
    /// <returns>Объект экспортер.</returns>
    private static IExporter GetExporter()
    {
      return new PackingDecorator(new EncryptingDecorator(new LocalStorageExporter()));
    }
  }
}
