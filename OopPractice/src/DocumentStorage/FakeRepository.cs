using OopPractice.Document;

namespace OopPractice.DocumentStorage
{
  /// <summary>
  /// Репозиторий-заглушка документов/компонентов.
  /// </summary>
  internal sealed class FakeRepository : IRepository
  {
    /// <summary>
    /// Загрузить документ/комплект.
    /// </summary>
    /// <returns>Документ/комплект.</returns>
    public IDocumentComponent Load()
    {
      IdGenerator generator = IdGenerator.Instance;
      var doc1 = new DocumentComponent("Документ 1", generator.GetId());
      var doc2 = new DocumentComponent("Документ 2", generator.GetId());
      var comp1 = new DocumentComposite("Комплект 1", generator.GetId());
      comp1.Add(doc1);
      comp1.Add(doc2);
      var doc3 = new DocumentComponent("Документ 3", generator.GetId());
      var comp2 = new DocumentComposite("Комплект 2", generator.GetId());
      comp2.Add(doc3);
      comp2.Add(comp1);

      return comp2;
    }
  }
}
