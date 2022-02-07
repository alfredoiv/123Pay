using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            string AdminRoleGuid = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = AdminRoleGuid,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );

            var pwHasher = new PasswordHasher<ApplicationUser>();

            string UserGuid = Guid.NewGuid().ToString();
            modelBuilder.Entity<ApplicationUser>().HasData(
                new IdentityUser
                {
                    Id = UserGuid,
                    UserName = "administrator",
                    NormalizedUserName = "ADMINISTRATOR",
                    Email = "alfredoiv.magpantay@yahoo.com",
                    NormalizedEmail = "ALFREDOIV.MAGPANTAY@YAHOO.COM",
                    PasswordHash = pwHasher.HashPassword(null, "test123")
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = AdminRoleGuid,
                    UserId = UserGuid
                }
            );

            modelBuilder.Entity<PaymentRequest>().HasData(
                new PaymentRequest
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100001",
                    AccountNo = "8011223301",
                    AccountName = "Customer 1",
                    Merchant = "AT&T",
                    Amount = 100,
                    OtherDetails = "Other Details 1",
                    Status = Status.Pending,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 2,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100002",
                    AccountNo = "8011223302",
                    AccountName = "Customer 2",
                    Merchant = "Netflix",
                    Amount = 200,
                    OtherDetails = "Other Details 2",
                    Status = Status.Processing,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 3,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100003",
                    AccountNo = "8011223303",
                    AccountName = "Customer 3",
                    Merchant = "Amazon",
                    Amount = 300,
                    OtherDetails = "Other Details 3",
                    Status = Status.Failed,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 4,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100004",
                    AccountNo = "8011223304",
                    AccountName = "Customer 4",
                    Merchant = "EBay",
                    Amount = 400,
                    OtherDetails = "Other Details 4",
                    Status = Status.Done,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 5,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100005",
                    AccountNo = "8011223305",
                    AccountName = "Customer 5",
                    Merchant = "TELEPAY",
                    Amount = 500,
                    OtherDetails = "Other Details 5",
                    Status = Status.Pending,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 6,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100006",
                    AccountNo = "8011223306",
                    AccountName = "Customer 6",
                    Merchant = "AT&T",
                    Amount = 600,
                    OtherDetails = "Other Details 6",
                    Status = Status.Pending,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 7,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100007",
                    AccountNo = "8011223307",
                    AccountName = "Customer 7",
                    Merchant = "Netflix",
                    Amount = 700,
                    OtherDetails = "Other Details 7",
                    Status = Status.Processing,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 8,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100008",
                    AccountNo = "8011223308",
                    AccountName = "Customer 8",
                    Merchant = "Amazon",
                    Amount = 800,
                    OtherDetails = "Other Details 8",
                    Status = Status.Failed,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 9,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100009",
                    AccountNo = "8011223309",
                    AccountName = "Customer 9",
                    Merchant = "EBay",
                    Amount = 900,
                    OtherDetails = "Other Details 9",
                    Status = Status.Done,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 10,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100010",
                    AccountNo = "8011223310",
                    AccountName = "Customer 10",
                    Merchant = "TELEPAY",
                    Amount = 1000,
                    OtherDetails = "Other Details 10",
                    Status = Status.Pending,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 11,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100011",
                    AccountNo = "8011223311",
                    AccountName = "Customer 11",
                    Merchant = "AT&T",
                    Amount = 1100,
                    OtherDetails = "Other Details 11",
                    Status = Status.Pending,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 12,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100012",
                    AccountNo = "8011223312",
                    AccountName = "Customer 12",
                    Merchant = "Netflix",
                    Amount = 1200,
                    OtherDetails = "Other Details 12",
                    Status = Status.Processing,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 13,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100013",
                    AccountNo = "8011223313",
                    AccountName = "Customer 13",
                    Merchant = "Amazon",
                    Amount = 1300,
                    OtherDetails = "Other Details 13",
                    Status = Status.Failed,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 14,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100014",
                    AccountNo = "8011223314",
                    AccountName = "Customer 14",
                    Merchant = "EBay",
                    Amount = 1400,
                    OtherDetails = "Other Details 14",
                    Status = Status.Done,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 15,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100015",
                    AccountNo = "8011223315",
                    AccountName = "Customer 15",
                    Merchant = "TELEPAY",
                    Amount = 1500,
                    OtherDetails = "Other Details 15",
                    Status = Status.Pending,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 16,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100016",
                    AccountNo = "8011223316",
                    AccountName = "Customer 16",
                    Merchant = "AT&T",
                    Amount = 1600,
                    OtherDetails = "Other Details 16",
                    Status = Status.Pending,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 17,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100017",
                    AccountNo = "8011223317",
                    AccountName = "Customer 17",
                    Merchant = "Netflix",
                    Amount = 1700,
                    OtherDetails = "Other Details 17",
                    Status = Status.Processing,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 18,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100018",
                    AccountNo = "8011223318",
                    AccountName = "Customer 18",
                    Merchant = "Amazon",
                    Amount = 1800,
                    OtherDetails = "Other Details 18",
                    Status = Status.Failed,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 19,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100019",
                    AccountNo = "8011223319",
                    AccountName = "Customer 19",
                    Merchant = "EBay",
                    Amount = 1900,
                    OtherDetails = "Other Details 19",
                    Status = Status.Done,
                    ProcessorId = UserGuid
                },
                new PaymentRequest
                {
                    Id = 20,
                    CreateDate = DateTime.Now,
                    ClientName = "ABC Pay",
                    CustomerName = "Wan Talamera",
                    ReferenceNo = "PR2022020100020",
                    AccountNo = "8011223320",
                    AccountName = "Customer 20",
                    Merchant = "TELEPAY",
                    Amount = 2000,
                    OtherDetails = "Other Details 20",
                    Status = Status.Pending,
                    ProcessorId = UserGuid
                }
            );
        }
    }
}
