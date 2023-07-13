using MongoDB.Driver;
using sinafavalia.api.interfaces;
using sinafavalia.api.models;

namespace sinafavalia.api.data
{
    public class Repository : IRepository
    {
        private readonly IMongoCollection<MeioPagamento> _meioPGCollect;
        public Repository(IDatabaseConfig databaseConfig)
        {
            // _context = context;
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _meioPGCollect = database.GetCollection<MeioPagamento>(databaseConfig.CollectionName);
        }
        // public void CreateData<T>(T entity) where T : class
        // {
        //     _context.Add(entity);
        // }

        // public void DeleteData<T>(T entity) where T : class
        // {
        //     _context.Remove(entity);
        // }

        // public async Task<bool> SaveDataAsynch()
        // {
        //     return (await _context.SaveChangesAsync() > 0);
        // }

        // public void UpdateData<T>(T entity) where T : class
        // {
        //     _context.Update(entity);
        // }


        // public async Task<Boleto[]> GetAllBoletoAsynch()
        // {
        //     IQueryable<Boleto>? query = _context.Boletos;

        //     query = query!.AsNoTracking()
        //                  .OrderBy(c => c.Id);

        //     return await query.ToArrayAsync();
        // }

        // public async Task<Boleto> GetBoletoAsynchById(int boletoId)
        // {
        //     IQueryable<Boleto>? query = _context.Boletos;

        //     query = query!.AsNoTracking().Where(c => c.Id == boletoId).OrderBy(c => c.Id);

        //     var retorno = await query.FirstOrDefaultAsync();

        //     return retorno!;
        // }

        // public async Task<Pix[]> GetAllPixAsynch()
        // {
        //     IQueryable<Pix>? query = _context.Pixes;

        //     query = query!.AsNoTracking()
        //                  .OrderBy(c => c.Id);

        //     return await query.ToArrayAsync();
        // }

        // public async Task<Pix> GetPixAsynchById(int pixId)
        // {
        //     IQueryable<Pix>? query = _context.Pixes;

        //     query = query!.AsNoTracking().Where(c => c.Id == pixId).OrderBy(c => c.Id);

        //     var retorno = await query.FirstOrDefaultAsync();

        //     return retorno!;
        // }

        public async Task<List<MeioPagamento>> GetAllMeioPagAsynch()
        {
            return await _meioPGCollect.Find(MeioPagamento => true).ToListAsync();
        }

        public async Task<MeioPagamento> GetMeioPagAsynchById(string meiopagId)
        {
            return await _meioPGCollect.Find(t => t.Id == meiopagId).FirstOrDefaultAsync();
        }
    }
}