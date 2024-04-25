using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using SocialSiteClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mapping
{
    public class UserMapProfile : Profile
    {
        public UserMapProfile() 
        {
            CreateMap<CreateUserRequest, User>()
                //.ForMember(dest => dest.EmailConfirmed, opt => opt.MapFrom(src => src.Banned))
                .ForMember(dest => dest.Banned, opt => opt.MapFrom(src => src.Banned))
                .ForMember(dest => dest.BannedDate, opt => opt.MapFrom(src => src.BannedDate))
                .ForMember(dest => dest.BannedEntities, null)
                .ForMember(dest => dest.Banner, null)
                .ForMember(dest => dest.BannerId, opt => opt.MapFrom(src => src.BannerId))
                .ForMember(dest => dest.BanReason, opt => opt.MapFrom(src => src.BanReason))
                .ForMember(dest => dest.Comments, null)
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.FriendId, opt => opt.MapFrom(src => src.FriendId))
                .ForMember(dest => dest.Friends, null)
                .ForMember(dest => dest.GroupMembers, null)
                .ForMember(dest => dest.Groups, null)
                .ForMember(dest => dest.Likes, null)
                .ForMember(dest => dest.Messages, null)
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Nickname, opt => opt.MapFrom(src => src.Nickname))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Posts, null)
                .ForMember(dest => dest.ReceivedMessages, null)
                .ForMember(dest => dest.SentMessages, null)
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname));
            CreateMap<User, SingleUserResponse>();                                                                                                                                                                                                                                                                           
        }
    }
}
