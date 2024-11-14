using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        //Specify to Automapper what we want to map from and to.
         //IncludeMembers specify that members/properties from another object should be included in the mapping.
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(d => d.Item, o => o.MapFrom(s => s));
            //d specifies that we're mapping to the Item property of the destination object (Auction in this case).
            //o specifies how the mapping should happen.
            //s "map the entire source object (CreateAuctionDto) to the Item property in the Auction object.
        CreateMap<CreateAuctionDto, Item>();

    }
}