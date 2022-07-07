using DeveloperRoadmapApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DeveloperRoadmapApi.DatabaseContext
{
public class ApplicationDbContext : DbContext
{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

public DbSet<Language> Languages { get; set; }
    }
}
    