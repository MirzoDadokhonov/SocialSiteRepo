﻿using AutoMapper;
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
    public class CommentMapProfile : Profile
    {
        public CommentMapProfile() 
        {
            CreateMap<CreateCommentRequest, Comment>();
            CreateMap<Comment, SingleCommentResponse>();                                                                                                                                                                                                                                                                           
        }
    }
}
