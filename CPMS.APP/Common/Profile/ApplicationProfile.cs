﻿using CPMS.APP.Models;
using CPMS.BL.Entities;
using CPMS.DAL.DTO;

namespace CPMS.BL.Common.Profile
{
    /// <summary>
    /// Class create maps of models and register it to the application.
    /// </summary>
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Address, AddressDTO>()
                .ReverseMap();

            CreateMap<Address, AddressModel>()
                .ReverseMap();

            CreateMap<TaskItem, TaskDTO>()
                .ReverseMap();

            CreateMap<TaskItem, TaskModel>()
                .ReverseMap();

            CreateMap<Project, ProjectDTO>()
                .ReverseMap();

            CreateMap<Project, ProjectModel>()
                .ReverseMap();

            CreateMap<BillingInfo, BillingInfoDTO>()
                .ReverseMap();

            CreateMap<BillingInfo, BillingInfoModel>()
                .ReverseMap();

            CreateMap<Customer, CustomerDTO>()
                .ReverseMap();

            CreateMap<Customer, CustomerModel>()
                .ReverseMap();

            CreateMap<Developer, DeveloperDTO>()
                .ReverseMap();

            CreateMap<Developer, DeveloperModel>()
                .ReverseMap();

            CreateMap<Time, TimeDTO>()
                .ReverseMap();

            CreateMap<Time, TimeModel>()
                .ReverseMap();
        }
    }
}
