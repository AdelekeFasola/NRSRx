using IkeMtz.NRSRx.Core.EntityFramework;
using Microsoft.EntityFrameworkCore;
using IkeMtz.Samples.WebApi.Models;

namespace IkeMtz.Samples.WebApi.Data
{
  public interface IDatabaseContext : IAuditableDbContext
  {
    DbSet<Item> Items { get; set; }
  }
}

