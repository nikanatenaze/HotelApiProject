using HotelAPIProject.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelAPIProject.Repository
{
    public class HotelSystemRepository<T> : IHotelSystemRepository<T> where T : class {
        private DbSet<T> Table;
        private readonly DataContext Context;

        public HotelSystemRepository(DataContext data)
        {
            Context = data;
        }

        public async Task<T> CreateAsync(T dbRecord)
        {
            await Table.AddAsync(dbRecord);
            Context.SaveChangesAsync();
            return dbRecord;
        }

        public async Task<bool> DeleteAsync(T dbRecord)
        {
            Table.Remove(dbRecord);
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await Table.AsNoTracking().FirstOrDefaultAsync(filter);
        }

        public async Task<T> UpdateAsync(T dbRecord)
        {
            Table.Update(dbRecord);
            await Context.SaveChangesAsync();
            return dbRecord;
        }
    }
}
