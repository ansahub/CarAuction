using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

public class UpdateAuctionDto
{
    public required string Make { get; set; }
    public required string Model { get; set; }
    public int? Year { get; set; }
    public string Color { get; set; }
    public int? Mileage { get; set; }
}
