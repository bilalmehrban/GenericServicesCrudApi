// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GenericServicesCrud.Common.Enum;
using Microsoft.AspNetCore.Identity;

namespace GenericServicesCrud.Infrastructure.Models.Users
{
    public class User : IdentityUser<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id
        {
            get => base.Id;
            set => base.Id = value;
        }

        public override string UserName
        {
            get => base.Email;
            set => base.Email = value;
        }

        public override string PhoneNumber
        {
            get => base.PhoneNumber;
            set => base.PhoneNumber = value;
        }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public UserStatus Status { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
