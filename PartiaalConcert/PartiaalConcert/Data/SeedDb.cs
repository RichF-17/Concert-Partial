using PartiaalConcert.Data.Entities;

namespace PartiaalConcert.Data
{
    public class SeedDb
    {
        private DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckEntranceAsync();
            await CheckTicketAsync();
        }

        private async Task CheckTicketAsync()
        {
           if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 5000; i++)
                {
                    _context.Tickets.Add(new Tickets
                    {
                        Document = null,
                        Entrance = null,
                        Date = DateTime.Now,
                        WasUsed = false,
                    });
                }
            }
           await _context.SaveChangesAsync();
        }

        private async Task CheckEntranceAsync()
        {
            if (!_context.Entrances.Any())
            {
                _context.Entrances.Add(new Entrance { Description = "NORTE" });
                _context.Entrances.Add(new Entrance { Description = "SUR" });
                _context.Entrances.Add(new Entrance { Description = "ORIENTE" });
                _context.Entrances.Add(new Entrance { Description = "OCCIDENTE" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
