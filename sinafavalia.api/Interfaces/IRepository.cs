using sinafavalia.api.models;

namespace sinafavalia.api.interfaces
{
    public interface IRepository
    {
        // void CreateData<T>(T entity) where T : class;
        // void UpdateData<T>(T entity) where T : class;
        // void DeleteData<T>(T entity) where T : class;
        // Task<bool> SaveDataAsynch();

        // Meios de Pagamento
        Task<List<MeioPagamento>> GetAllMeioPagAsynch();
        Task<MeioPagamento> GetMeioPagAsynchById(string meiopagId);

        // Boleto
        // Task<Boleto[]> GetAllBoletoAsynch();
        // Task<Boleto> GetBoletoAsynchById(int boletoId);

        // Pix
        // Task<Pix[]> GetAllPixAsynch();
        // Task<Pix> GetPixAsynchById(int pixId);
    }
}