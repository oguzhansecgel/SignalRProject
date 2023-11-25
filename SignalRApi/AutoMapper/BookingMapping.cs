using AutoMapper;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.AutoMapper
{
	public class BookingMapping : Profile
	{
		public BookingMapping()
		{
			CreateMap<Booking, ResultBookingDto>().ReverseMap();
			CreateMap<Booking, CreateBookingDto>().ReverseMap();
			CreateMap<Booking, GetBookingDto>().ReverseMap();
			CreateMap<Booking, UpdateBookingDto>().ReverseMap();
		}
	}
}
