﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ePizzaHub.Infrastructure.Entities;

public partial class UserToken
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string AccessToken { get; set; }

    public string RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiryTime { get; set; }
}