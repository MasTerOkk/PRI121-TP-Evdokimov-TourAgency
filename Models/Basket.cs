using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using TourAgency.Models;

namespace agency.Models
{
    // Корзина
    public class Basket
    {
        public int Id { get; set; }
        [DefaultValue(0)]
        public int PersonsCount { get; set; }
        public int? TourId { get; set; }
        public Tour? Tour {  get; set; }
        public string? UserId { get; set; }
        public IdentityUser? user {  get; set; }

    }
}
