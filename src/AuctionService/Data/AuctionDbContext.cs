using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

/// <summary>
/// DbContext is a core class in Entity Framework 
/// that represents a session with the database.
/// It provides the main API for querying and saving data.
/// </summary>
public class AuctionDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Auction> Auctions { get; set; }

}