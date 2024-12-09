namespace Client.Interfaces
{
    public interface IDocumentIntelligenceClient
    {
        Task<string> ExtractText(Stream documentStream);
    }
}