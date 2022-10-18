using AutoMapper;
using TargetSettingTool.Application.Features.Categories.Commands.CreateCategory;
using TargetSettingTool.Application.Features.Categories.Commands.StoredProcedure;
using TargetSettingTool.Application.Features.Categories.Queries.GetCategoriesList;
using TargetSettingTool.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using TargetSettingTool.Application.Features.Events.Commands.CreateEvent;
using TargetSettingTool.Application.Features.Events.Commands.Transaction;
using TargetSettingTool.Application.Features.Events.Commands.UpdateEvent;
using TargetSettingTool.Application.Features.Events.Queries.GetEventDetail;
using TargetSettingTool.Application.Features.Events.Queries.GetEventsExport;
using TargetSettingTool.Application.Features.Events.Queries.GetEventsList;
using TargetSettingTool.Application.Features.Orders.GetOrdersForMonth;
using TargetSettingTool.Domain.Entities;

namespace TargetSettingTool.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {          
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, TransactionCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, StoredProcedureCommand>();
            CreateMap<Category, StoredProcedureDto>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();
        }
    }
}
